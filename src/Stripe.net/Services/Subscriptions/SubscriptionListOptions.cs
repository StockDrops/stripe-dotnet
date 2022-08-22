// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SubscriptionListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonPropertyName("current_period_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CurrentPeriodEnd { get; set; }

        [JsonPropertyName("current_period_start")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CurrentPeriodStart { get; set; }

        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("plan")]
        public string Plan { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("test_clock")]
        public string TestClock { get; set; }
    }
}
