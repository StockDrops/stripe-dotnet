// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class InvoiceItemPeriod : StripeEntity<InvoiceItemPeriod>
    {
        /// <summary>
        /// The end of the period, which must be greater than or equal to the start.
        /// </summary>
        [JsonPropertyName("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime End { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The start of the period.
        /// </summary>
        [JsonPropertyName("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Start { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
