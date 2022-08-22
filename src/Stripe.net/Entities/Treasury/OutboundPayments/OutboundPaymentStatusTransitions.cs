// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class OutboundPaymentStatusTransitions : StripeEntity<OutboundPaymentStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when an OutboundPayment changed status to <c>canceled</c>.
        /// </summary>
        [JsonPropertyName("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Timestamp describing when an OutboundPayment changed status to <c>failed</c>.
        /// </summary>
        [JsonPropertyName("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// Timestamp describing when an OutboundPayment changed status to <c>posted</c>.
        /// </summary>
        [JsonPropertyName("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PostedAt { get; set; }

        /// <summary>
        /// Timestamp describing when an OutboundPayment changed status to <c>returned</c>.
        /// </summary>
        [JsonPropertyName("returned_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ReturnedAt { get; set; }
    }
}
