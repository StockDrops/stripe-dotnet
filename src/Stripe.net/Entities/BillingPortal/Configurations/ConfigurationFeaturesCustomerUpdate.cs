// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ConfigurationFeaturesCustomerUpdate : StripeEntity<ConfigurationFeaturesCustomerUpdate>
    {
        /// <summary>
        /// The types of customer updates that are supported. When empty, customers are not
        /// updateable.
        /// </summary>
        [JsonPropertyName("allowed_updates")]
        public List<string> AllowedUpdates { get; set; }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
