namespace Stripe.Infrastructure.JsonConverters.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Text.Json.Serialization.Metadata;
    using System.Threading.Tasks;
    using System.Xml;
    using Stripe.Infrastructure.Extensions;

    /// <summary>
    /// Base class for converters that are able to resume after reading or writing to a buffer.
    /// This is used when the Stream-based serialization APIs are used.
    /// </summary>
    /// <typeparam name="T">The type to convert.</typeparam>
    public class SimpleConcreteTypeConverter<T> : JsonConverter<T>
    {
        private readonly IReadOnlyList<PropertyInfo> dtoProperties;
        private readonly Dictionary<PropertyInfo, string[]> readNameOverrides;
        private readonly Func<Dictionary<PropertyInfo, object>, T> factory;

        public SimpleConcreteTypeConverter(Func<Dictionary<PropertyInfo, object>, T> factory)
        {
            this.readNameOverrides = new Dictionary<PropertyInfo, string[]>();
            this.dtoProperties = typeof(T).GetPublicProperties().ToList();
            this.factory = factory;
        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            var readProperties = new Dictionary<PropertyInfo, object>();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = reader.GetString();

                    // read one more to get to the value to read.
                    if (!reader.Read())
                    {
                        throw new JsonException();
                    }

                    var property = this.dtoProperties.FirstOrDefault(p => GetReadJsonPropertyName(p, options)[0] == propertyName);

                    if (property != null)
                    {
                        var propertyType = property.PropertyType;

                        var propertyValue = JsonSerializer.Deserialize(ref reader, propertyType, options);

                        if (!readProperties.ContainsKey(property))
                        {
                            readProperties.Add(property, propertyValue);
                        }
                    }
                }
            }

            return this.factory(readProperties);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        private string[] GetReadJsonPropertyName(PropertyInfo dtoProperty, JsonSerializerOptions options)
        {
            return this.readNameOverrides.TryGetValue(dtoProperty, out var overriddenName)
                ? overriddenName
                : new[]
                {
                    (dtoProperty.GetCustomAttribute(typeof(JsonPropertyNameAttribute)) as JsonPropertyNameAttribute)?.Name ?? options.PropertyNamingPolicy?.ConvertName(dtoProperty.Name) ?? dtoProperty.Name,
                };
        }
    }
}
