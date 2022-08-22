namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionSchedulePhasePlanBillingThresholds : StripeEntity<SubscriptionSchedulePhasePlanBillingThresholds>
    {
        [JsonPropertyName("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
