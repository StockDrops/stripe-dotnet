// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionAutomaticTax : StripeEntity<SubscriptionAutomaticTax>
    {
        /// <summary>
        /// Whether Stripe automatically computes tax on this subscription.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
