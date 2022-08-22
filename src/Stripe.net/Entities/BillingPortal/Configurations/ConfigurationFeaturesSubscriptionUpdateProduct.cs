// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ConfigurationFeaturesSubscriptionUpdateProduct : StripeEntity<ConfigurationFeaturesSubscriptionUpdateProduct>
    {
        /// <summary>
        /// The list of price IDs which, when subscribed to, a subscription can be updated.
        /// </summary>
        [JsonPropertyName("prices")]
        public List<string> Prices { get; set; }

        /// <summary>
        /// The product ID.
        /// </summary>
        [JsonPropertyName("product")]
        public string Product { get; set; }
    }
}
