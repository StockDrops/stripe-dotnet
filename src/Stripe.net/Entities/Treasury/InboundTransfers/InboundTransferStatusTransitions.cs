// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class InboundTransferStatusTransitions : StripeEntity<InboundTransferStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>canceled</c>.
        /// </summary>
        [JsonPropertyName("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>failed</c>.
        /// </summary>
        [JsonPropertyName("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>succeeded</c>.
        /// </summary>
        [JsonPropertyName("succeeded_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SucceededAt { get; set; }
    }
}
