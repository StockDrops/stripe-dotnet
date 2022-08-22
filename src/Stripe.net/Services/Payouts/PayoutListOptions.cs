// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class PayoutListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("arrival_date")]
        [JsonConverter(typeof(AnyOfConverterFactory))]
        public AnyOf<DateTime?, DateRangeOptions> ArrivalDate { get; set; }

        [JsonPropertyName("destination")]
        public string Destination { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
