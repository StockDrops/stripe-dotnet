// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    public class ReaderProcessSetupIntentOptions : BaseOptions
    {
        /// <summary>
        /// Customer Consent Collected.
        /// </summary>
        [JsonPropertyName("customer_consent_collected")]
        public bool? CustomerConsentCollected { get; set; }

        /// <summary>
        /// SetupIntent ID.
        /// </summary>
        [JsonPropertyName("setup_intent")]
        public string SetupIntent { get; set; }
    }
}
