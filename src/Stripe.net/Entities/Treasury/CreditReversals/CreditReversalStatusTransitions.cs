// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class CreditReversalStatusTransitions : StripeEntity<CreditReversalStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the CreditReversal changed status to <c>posted</c>.
        /// </summary>
        [JsonPropertyName("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PostedAt { get; set; }
    }
}
