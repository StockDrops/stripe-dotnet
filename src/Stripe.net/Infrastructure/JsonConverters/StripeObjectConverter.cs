namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// This converter can be used to deserialize any Stripe object. It is mainly useful for
    /// polymorphic attributes, when the property's type is an interface instead of a concrete type.
    /// In this case, the converter will use the value of the `object` key in the JSON payload to
    /// decide which concrete type to instantiate. If no concrete type is found (or if one is found,
    /// but it's not compatible with the expected interface), then the converter returns `null`.
    /// </summary>
    /// <typeparam name="T">The.</typeparam>
    public class StripeObjectConverter<T> : JsonConverter<T>
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
            return objectType.GetTypeInfo().IsInterface;
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The serialization options.</param>
        /// <returns>The object value.</returns>
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Utf8JsonReader readerClone = reader;

            if (readerClone.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            if (readerClone.TokenType == JsonTokenType.Null)
            {
                return default(T);
            }

            var objectValue = string.Empty;
            var startsSeen = 0;

            while (readerClone.Read())
            {
                if (readerClone.TokenType == JsonTokenType.StartObject)
                {
                    startsSeen++;
                }

                if (readerClone.TokenType == JsonTokenType.EndObject)
                {
                    if (startsSeen == 0)
                    {
                        break;
                    }

                    startsSeen--; // we have come back to parity between { and } signs.
                }

                if (readerClone.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = readerClone.GetString();

                    if (propertyName == "object" && readerClone.Read() && readerClone.TokenType == JsonTokenType.String)
                    {
                        objectValue = readerClone.GetString();
                        break;
                    }
                }
            }

            Type concreteType = StripeTypeRegistry.GetConcreteType(typeToConvert, objectValue);
            if (concreteType == null)
            {
                // Couldn't find a concrete type to instantiate, return null.
                // we need to advance the reader until the end or else we will get  The converter 'Stripe.Infrastructure.StripeObjectConverter`1[Stripe.IBalanceTransactionSource]' read too much or not enough.
                while (reader.TokenType != JsonTokenType.EndObject)
                {
                    _ = reader.TrySkip();
                }

                return default(T);
            }

            return (T)JsonSerializer.Deserialize(ref reader, concreteType, options);
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="options">The serialization options.</param>
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
