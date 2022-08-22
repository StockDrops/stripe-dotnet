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
    /// <typeparam name="T">The types available.</typeparam>
    public class AnyOfConverter<T> : JsonConverter<T>
        where T : IAnyOf
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return default(T);
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
                    reader = clone;
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

            return (T)Activator.CreateInstance(typeToConvert, o);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
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
