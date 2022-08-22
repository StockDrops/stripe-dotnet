namespace Stripe.Infrastructure
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Converts a <see cref="DateTime"/> to and from Unix epoch time.
    /// </summary>
    /// <remarks>
    /// This is a somewhat simplified version of the converter with the same name that was added in
    /// Newtonsoft.Json 11.0. Once we bump the minimum version of Newtonsoft.Json to 11.0, we can
    /// start using the provided converter and get rid of this class.
    /// </remarks>
    public class UnixDateTimeConverter : JsonConverter<DateTime>
    {
        internal static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private static bool IsNullable(Type t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            if (t.IsValueType)
            {
                return t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
            }

            return true;
        }

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            bool nullable = IsNullable(typeToConvert);
            if (reader.TokenType == JsonTokenType.Null)
            {
                if (!nullable)
                {
                    throw new JsonException(string.Format("Cannot convert null value to {0}.", typeToConvert));
                }

                return default;
            }

            long seconds;

            if (reader.TokenType == JsonTokenType.Number)
            {
                seconds = reader.GetInt64();
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                if (!long.TryParse(reader.GetString(), out seconds))
                {
                    throw new JsonException(string.Format("Cannot convert invalid value to {0}.", typeToConvert));
                }
            }
            else
            {
                throw new JsonException(string.Format("Unexpected token parsing date. Expected Integer or String, got {0}.", reader.TokenType));
            }

            if (seconds >= 0)
            {
                return DateTimeOffset.FromUnixTimeSeconds(seconds).UtcDateTime;
            }
            else
            {
                throw new JsonException(string.Format("Cannot convert value that is before Unix epoch of 00:00:00 UTC on 1 January 1970 to {0}.", typeToConvert));
            }
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            long seconds = new DateTimeOffset(value).ToUnixTimeSeconds();

            if (seconds < 0)
            {
                throw new JsonException("Cannot convert date value that is before Unix epoch of 00:00:00 UTC on 1 January 1970.");
            }

            writer.WriteNumberValue(seconds);
        }
    }
}
