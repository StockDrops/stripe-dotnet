namespace Stripe.Infrastructure
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    internal static class JsonUtils
    {
        private static readonly JsonSerializerOptions DefaultSerializerSettings = new JsonSerializerOptions()
        {
            MaxDepth = 128,
        };

        /// <summary>
        /// Deserializes the JSON to the specified .NET type using
        /// <see cref="JsonSerializerOptions"/>.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="settings">
        /// The <see cref="JsonSerializerOptions"/> used to deserialize the object.
        /// </param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static T DeserializeObject<T>(
            string value,
            JsonSerializerOptions settings = null)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return JsonSerializer.Deserialize<T>(value, settings ?? DefaultSerializerSettings);
        }

        /// <summary>
        /// Deserializes the JSON to the specified .NET type using
        /// <see cref="JsonSerializerOptions"/>.
        /// </summary>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="type">The type of the object to deserialize to.</param>
        /// <param name="settings">
        /// The <see cref="JsonSerializerOptions"/> used to deserialize the object.
        /// </param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static object DeserializeObject(
            string value,
            Type type,
            JsonSerializerOptions settings = null)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return JsonSerializer.Deserialize(value, type, settings ?? DefaultSerializerSettings);
        }

        /// <summary>
        /// Serializes the specified object to a JSON string without using any default settings.
        /// </summary>
        /// <param name="value">The object to serialize.</param>
        /// <param name="settings">
        /// The <see cref="JsonSerializerOptions"/> used to serialize the object.
        /// </param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string SerializeObject(
            object value,
            JsonSerializerOptions settings = null) // Formatting has no equivalent in STJ
        {
            return JsonSerializer.Serialize(value, settings);
        }
    }
}
