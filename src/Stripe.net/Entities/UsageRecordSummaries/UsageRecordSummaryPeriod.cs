// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class UsageRecordSummaryPeriod : StripeEntity<UsageRecordSummaryPeriod>
    {
        /// <summary>
        /// The end date of this usage period. All usage up to and including this point in time is
        /// included.
        /// </summary>
        [JsonPropertyName("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? End { get; set; }

        /// <summary>
        /// The start date of this usage period. All usage after this point in time is included.
        /// </summary>
        [JsonPropertyName("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Start { get; set; }
    }
}
