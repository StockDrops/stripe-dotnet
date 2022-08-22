// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkLineItemAdjustableQuantityOptions : INestedOptions
    {
        /// <summary>
        /// Set to true if the quantity can be adjusted to any non-negative Integer.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The maximum quantity the customer can purchase. By default this value is 99. You can
        /// specify a value up to 99.
        /// </summary>
        [JsonPropertyName("maximum")]
        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum quantity the customer can purchase. By default this value is 0. You can
        /// specify a value up to 98. If there is only one item in the cart then that item's
        /// quantity cannot go down to 0.
        /// </summary>
        [JsonPropertyName("minimum")]
        public long? Minimum { get; set; }
    }
}
