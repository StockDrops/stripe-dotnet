// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionSchedulePhaseItemBillingThresholdsOptions : INestedOptions
    {
        /// <summary>
        /// Usage threshold that triggers the subscription to advance to a new billing period.
        /// </summary>
        [JsonPropertyName("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
