namespace Stripe.Infrastructure
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// This converter is used to deserialize objects inheriting from StripeEntity.
    /// It sets the RawJObject property so that undocumented and unsupported fields can be accessed or logged.
    /// </summary>
    /// <typeparam name="T">The type of the stripe entity.</typeparam>
    public class StripeEntityConverter<T> : JsonConverter<T>
        where T : StripeEntity
    {
        public StripeEntityConverter()
        {
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The options for the serializer.</param>
        /// <returns>The object value.</returns>
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            JsonDocument jToken = JsonDocument.ParseValue(ref reader);
            var e = jToken.Deserialize<T>();
            e?.SetRawJObject(jToken);
            return e;
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="options">The options.</param>
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }
}
