// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CustomerTax : StripeEntity<CustomerTax>
    {
        /// <summary>
        /// Surfaces if automatic tax computation is possible given the current customer location
        /// information.
        /// One of: <c>failed</c>, <c>not_collecting</c>, <c>supported</c>, or
        /// <c>unrecognized_location</c>.
        /// </summary>
        [JsonPropertyName("automatic_tax")]
        public string AutomaticTax { get; set; }

        /// <summary>
        /// A recent IP address of the customer used for tax reporting and tax location inference.
        /// </summary>
        [JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The customer's location as identified by Stripe Tax.
        /// </summary>
        [JsonPropertyName("location")]
        public CustomerTaxLocation Location { get; set; }
    }
}
