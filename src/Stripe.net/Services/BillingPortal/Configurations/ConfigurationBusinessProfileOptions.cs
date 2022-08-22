// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Text.Json.Serialization;

    public class ConfigurationBusinessProfileOptions : INestedOptions
    {
        /// <summary>
        /// The messaging shown to customers in the portal.
        /// </summary>
        [JsonPropertyName("headline")]
        public string Headline { get; set; }

        /// <summary>
        /// A link to the business’s publicly available privacy policy.
        /// </summary>
        [JsonPropertyName("privacy_policy_url")]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// A link to the business’s publicly available terms of service.
        /// </summary>
        [JsonPropertyName("terms_of_service_url")]
        public string TermsOfServiceUrl { get; set; }
    }
}
