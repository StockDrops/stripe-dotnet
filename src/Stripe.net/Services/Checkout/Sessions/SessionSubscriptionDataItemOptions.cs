// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SessionSubscriptionDataItemOptions : INestedOptions
    {
        /// <summary>
        /// Plan ID for this item.
        /// </summary>
        [JsonPropertyName("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// The quantity of the subscription item being purchased. Quantity should not be defined
        /// when <c>recurring.usage_type=metered</c>.
        /// </summary>
        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to this item. When set, the <c>default_tax_rates</c> on
        /// <c>subscription_data</c> do not apply to this item.
        /// </summary>
        [JsonPropertyName("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
