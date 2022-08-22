namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Xml.Linq;

    /// <summary>
    /// Converts a <see cref="ExpandableField{T}"/> to and from JSON.
    /// </summary>
    /// <typeparam name="TItem">Type of the field when expanded.</typeparam>
    public class ExpandableFieldConverter<TItem> : JsonConverter<ExpandableField<TItem>>
        where TItem : IHasId
    {
        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The serializer's options.</param>
        /// <returns>The object value.</returns>
        public override ExpandableField<TItem> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = new ExpandableField<TItem>();

            switch (reader.TokenType)
            {
                case JsonTokenType.Null:
                    // Do nothing
                    break;

                case JsonTokenType.String:
                    value.Id = reader.GetString();
                    break;

                case JsonTokenType.StartObject:
                    var clonedReader = reader;
                    value.ExpandedObject = (TItem)JsonSerializer.Deserialize(ref reader, typeof(TItem), options);

                    // If we failed to deserialize the expanded object (e.g. because of an unknown
                    // type), make a last ditch attempt at getting the ID.
                    if (value.ExpandedObject == null)
                    {
                        value.Id = JsonSerializer.Deserialize<HasId>(ref clonedReader, options)?.Id;
                    }

                    break;

                default:
                    throw new JsonException(string.Format(
                        "Unexpected token when converting ExpandableField: {0}.",
                        reader.TokenType.ToString()));
            }

            return value;
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="options">The serializer's options.</param>
        public override void Write(Utf8JsonWriter writer, ExpandableField<TItem> value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case null:
                    writer.WriteNullValue();
                    break;

                case IExpandableField expandableField:
                    var valueToSerialize = expandableField.IsExpanded
                        ? expandableField.ExpandedObject
                        : expandableField.Id;
                    JsonSerializer.Serialize(writer, valueToSerialize, options);
                    break;

                default:
                    throw new JsonException(string.Format(
                        "Unexpected value when converting ExpandableField. Expected IExpandableField, got {0}.",
                        value.GetType()));
            }
        }
    }
}
