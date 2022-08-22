// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ShippingOptions : INestedOptions
    {
        /// <summary>
        /// Customer shipping address.
        /// </summary>
        [JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Customer name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Customer phone (including extension).
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
