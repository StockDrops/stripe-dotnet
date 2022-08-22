namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionSchedulePhasePlanBillingThresholdsOptions : INestedOptions
    {
        [JsonPropertyName("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
