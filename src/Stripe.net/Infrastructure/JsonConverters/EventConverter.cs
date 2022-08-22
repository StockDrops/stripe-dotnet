namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Nodes;
    using System.Text.Json.Serialization;
    using System.Xml.Linq;

    /// <summary>
    /// This converter is used to deserialize event objects regardless of which API version they're
    /// formatted with. In the general case, Stripe.net uses a specific API version
    /// (<see cref="StripeConfiguration.ApiVersion"/>), but events are a special case: when
    /// receiving an event object via a webhook notification, the object will be formatted with
    /// the Stripe account's default API version which may be different than Stripe.net's API
    /// version.
    /// </summary>
    public class EventConverter : JsonConverter<Event>
    {

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The serializer options.</param>
        /// <returns>The object value.</returns>
        public override Event Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            var readerClone = reader;
            EventRequest eventRequest = null;

            while (readerClone.Read())
            {
                if (readerClone.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = readerClone.GetString();

                    // Handle breaking change in API version 2017-05-25:
                    // Updates the `request` property on the Event object to be a hash containing the
                    // request ID and the idempotency key. Previously, `request` was just the ID.
                    if (propertyName == "request" && readerClone.Read())
                    {
                        if (readerClone.TokenType == JsonTokenType.String)
                        {
                            eventRequest = new EventRequest
                            {
                                Id = readerClone.GetString(),
                                IdempotencyKey = null,
                            };
                            break;
                        }
                    }
                }
            }

            if (eventRequest != null)
            {
                var jsonObject = JsonNode.Parse(ref reader);
                jsonObject["request"] = JsonNode.Parse(JsonSerializer.Serialize(eventRequest));

                // At this point, jsonObject should be formatted in a way that's compatible with
                // Stripe.net's API version.
                var value = jsonObject.Deserialize<Event>();

                // Store the raw object as a JToken
                if (value.Data != null)
                {
                    value.Data.RawObject = jsonObject["data"]["object"];
                }

                return value;
            }

            return (Event)JsonSerializer.Deserialize(ref reader, typeof(Event));
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="value">The value.</param>
        /// <param name="options">THe options.</param>
        public override void Write(Utf8JsonWriter writer, Event value, JsonSerializerOptions options)
        {
            throw new NotSupportedException("EventConverter should only be used while deserializing.");
        }
    }
}
