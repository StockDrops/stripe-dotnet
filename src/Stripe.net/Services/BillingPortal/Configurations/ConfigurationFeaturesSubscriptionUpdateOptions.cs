// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ConfigurationFeaturesSubscriptionUpdateOptions : INestedOptions
    {
        /// <summary>
        /// The types of subscription updates that are supported. When empty, subscriptions are not
        /// updateable.
        /// </summary>
        [JsonPropertyName("default_allowed_updates")]
        public List<string> DefaultAllowedUpdates { get; set; }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The list of products that support subscription updates.
        /// </summary>
        [JsonPropertyName("products")]
        public List<ConfigurationFeaturesSubscriptionUpdateProductOptions> Products { get; set; }

        /// <summary>
        /// Determines how to handle prorations resulting from subscription updates. Valid values
        /// are <c>none</c>, <c>create_prorations</c>, and <c>always_invoice</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }
    }
}
