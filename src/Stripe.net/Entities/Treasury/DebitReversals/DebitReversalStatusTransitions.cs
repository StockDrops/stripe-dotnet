// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class DebitReversalStatusTransitions : StripeEntity<DebitReversalStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the DebitReversal changed status to <c>completed</c>.
        /// </summary>
        [JsonPropertyName("completed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CompletedAt { get; set; }
    }
}
