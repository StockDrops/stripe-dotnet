// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("canceled_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CanceledAt { get; set; }

        [JsonPropertyName("completed_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CompletedAt { get; set; }

        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("released_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> ReleasedAt { get; set; }

        [JsonPropertyName("scheduled")]
        public bool? Scheduled { get; set; }
    }
}
