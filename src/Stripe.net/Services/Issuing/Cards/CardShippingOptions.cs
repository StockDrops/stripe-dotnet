// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardShippingOptions : INestedOptions
    {
        /// <summary>
        /// The address that the card is shipped to.
        /// </summary>
        [JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The name printed on the shipping label when shipping the card.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Shipment service.
        /// One of: <c>express</c>, <c>priority</c>, or <c>standard</c>.
        /// </summary>
        [JsonPropertyName("service")]
        public string Service { get; set; }

        /// <summary>
        /// Packaging options.
        /// One of: <c>bulk</c>, or <c>individual</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
