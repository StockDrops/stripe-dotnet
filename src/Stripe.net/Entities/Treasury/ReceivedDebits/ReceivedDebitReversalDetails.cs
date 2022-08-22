// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class ReceivedDebitReversalDetails : StripeEntity<ReceivedDebitReversalDetails>
    {
        /// <summary>
        /// Time before which a ReceivedDebit can be reversed.
        /// </summary>
        [JsonPropertyName("deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Set if a ReceivedDebit can't be reversed.
        /// One of: <c>already_reversed</c>, <c>deadline_passed</c>, <c>network_restricted</c>,
        /// <c>other</c>, or <c>source_flow_restricted</c>.
        /// </summary>
        [JsonPropertyName("restricted_reason")]
        public string RestrictedReason { get; set; }
    }
}
