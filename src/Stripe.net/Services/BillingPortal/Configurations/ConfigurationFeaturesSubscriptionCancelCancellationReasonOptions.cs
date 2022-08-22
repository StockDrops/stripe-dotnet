// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ConfigurationFeaturesSubscriptionCancelCancellationReasonOptions : INestedOptions
    {
        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Which cancellation reasons will be given as options to the customer.
        /// </summary>
        [JsonPropertyName("options")]
        public List<string> Options { get; set; }
    }
}
