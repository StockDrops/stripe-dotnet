// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ConfigurationFeaturesSubscriptionUpdateProductOptions : INestedOptions
    {
        /// <summary>
        /// The list of price IDs for the product that a subscription can be updated to.
        /// </summary>
        [JsonPropertyName("prices")]
        public List<string> Prices { get; set; }

        /// <summary>
        /// The product id.
        /// </summary>
        [JsonPropertyName("product")]
        public string Product { get; set; }
    }
}
