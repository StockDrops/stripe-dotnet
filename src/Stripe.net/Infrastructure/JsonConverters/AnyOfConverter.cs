namespace Stripe.Infrastructure
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Converts a <see cref="IAnyOf"/> to and from JSON.
    /// </summary>
    public class AnyOfConverter : JsonConverter<IAnyOf>
    {
        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        ///     <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            var result = typeof(IAnyOf).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
            return result;
        }

        public override IAnyOf Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            object o = null;

            // Try to deserialize with each possible type
            // var jToken = JToken.Load(reader);
            foreach (var type in typeToConvert.GenericTypeArguments)
            {
                try
                {
                    var clone = reader;
                    o = JsonSerializer.Deserialize(ref clone, type, options);

                    // If deserialization succeeds, stop
                    break;
                }
                catch (JsonException)
                {
                    // Do nothing, just try the next type
                }
            }

            if (o == null)
            {
                throw new JsonException(string.Format(
                    "Cannot deserialize the current JSON object into any of the expected types ({0}).",
                    string.Join(", ", typeToConvert.GenericTypeArguments.Select(t => t.FullName))));
            }

            return (IAnyOf)Activator.CreateInstance(typeToConvert, o);
        }

        public override void Write(Utf8JsonWriter writer, IAnyOf value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case null:
                    writer.WriteNullValue();
                    break;

                case IAnyOf anyOf:
                    JsonSerializer.Serialize(writer, anyOf.Value, anyOf.Value.GetType());
                    break;

                default:
                    throw new JsonException(string.Format(
                        "Unexpected value when converting AnyOf. Expected IAnyOf, got {0}.",
                        value.GetType()));
            }
        }
    }
}
