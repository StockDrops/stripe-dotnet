// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class TransactionStatusTransitions : StripeEntity<TransactionStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the Transaction changed status to <c>posted</c>.
        /// </summary>
        [JsonPropertyName("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PostedAt { get; set; }

        /// <summary>
        /// Timestamp describing when the Transaction changed status to <c>void</c>.
        /// </summary>
        [JsonPropertyName("void_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? VoidAt { get; set; }
    }
}
