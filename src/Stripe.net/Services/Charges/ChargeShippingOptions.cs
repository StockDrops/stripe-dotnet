// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargeShippingOptions : INestedOptions
    {
        /// <summary>
        /// Shipping address.
        /// </summary>
        [JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc.
        /// </summary>
        [JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Recipient name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Recipient phone (including extension).
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The tracking number for a physical product, obtained from the delivery service. If
        /// multiple tracking numbers were generated for this purchase, please separate them with
        /// commas.
        /// </summary>
        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
