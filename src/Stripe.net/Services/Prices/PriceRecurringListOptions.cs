namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class PriceRecurringListOptions : INestedOptions
    {
        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        [JsonPropertyName("usage_type")]
        public string UsageType { get; set; }
    }
}
