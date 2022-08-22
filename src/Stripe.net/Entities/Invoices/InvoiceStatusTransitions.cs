// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class InvoiceStatusTransitions : StripeEntity<InvoiceStatusTransitions>
    {
        /// <summary>
        /// The time that the invoice draft was finalized.
        /// </summary>
        [JsonPropertyName("finalized_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FinalizedAt { get; set; }

        /// <summary>
        /// The time that the invoice was marked uncollectible.
        /// </summary>
        [JsonPropertyName("marked_uncollectible_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? MarkedUncollectibleAt { get; set; }

        /// <summary>
        /// The time that the invoice was paid.
        /// </summary>
        [JsonPropertyName("paid_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PaidAt { get; set; }

        /// <summary>
        /// The time that the invoice was voided.
        /// </summary>
        [JsonPropertyName("voided_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? VoidedAt { get; set; }
    }
}
