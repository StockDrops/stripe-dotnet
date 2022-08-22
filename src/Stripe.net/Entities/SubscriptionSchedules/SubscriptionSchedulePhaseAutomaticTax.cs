// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionSchedulePhaseAutomaticTax : StripeEntity<SubscriptionSchedulePhaseAutomaticTax>
    {
        /// <summary>
        /// Whether Stripe automatically computes tax on invoices created during this phase.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
