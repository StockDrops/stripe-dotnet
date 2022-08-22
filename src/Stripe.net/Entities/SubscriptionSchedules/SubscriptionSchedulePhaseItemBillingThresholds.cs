// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionSchedulePhaseItemBillingThresholds : StripeEntity<SubscriptionSchedulePhaseItemBillingThresholds>
    {
        /// <summary>
        /// Usage threshold that triggers the subscription to create an invoice.
        /// </summary>
        [JsonPropertyName("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
