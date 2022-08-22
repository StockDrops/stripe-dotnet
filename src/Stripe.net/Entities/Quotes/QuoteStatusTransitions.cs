// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class QuoteStatusTransitions : StripeEntity<QuoteStatusTransitions>
    {
        /// <summary>
        /// The time that the quote was accepted. Measured in seconds since Unix epoch.
        /// </summary>
        [JsonPropertyName("accepted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// The time that the quote was canceled. Measured in seconds since Unix epoch.
        /// </summary>
        [JsonPropertyName("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// The time that the quote was finalized. Measured in seconds since Unix epoch.
        /// </summary>
        [JsonPropertyName("finalized_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FinalizedAt { get; set; }
    }
}
