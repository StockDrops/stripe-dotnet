// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PriceCurrencyOptionsCustomUnitAmount : StripeEntity<PriceCurrencyOptionsCustomUnitAmount>
    {
        /// <summary>
        /// The maximum unit amount the customer can specify for this item.
        /// </summary>
        [JsonPropertyName("maximum")]
        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum unit amount the customer can specify for this item. Must be at least the
        /// minimum charge amount.
        /// </summary>
        [JsonPropertyName("minimum")]
        public long? Minimum { get; set; }

        /// <summary>
        /// The starting unit amount which can be updated by the customer.
        /// </summary>
        [JsonPropertyName("preset")]
        public long? Preset { get; set; }
    }
}
