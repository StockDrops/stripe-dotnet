// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Text.Json.Serialization;

    public class ConfigurationFeaturesPaymentMethodUpdateOptions : INestedOptions
    {
        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
