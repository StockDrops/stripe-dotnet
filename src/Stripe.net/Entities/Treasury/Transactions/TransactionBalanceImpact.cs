// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class TransactionBalanceImpact : StripeEntity<TransactionBalanceImpact>
    {
        /// <summary>
        /// The change made to funds the user can spend right now.
        /// </summary>
        [JsonPropertyName("cash")]
        public long Cash { get; set; }

        /// <summary>
        /// The change made to funds that are not spendable yet, but will become available at a
        /// later time.
        /// </summary>
        [JsonPropertyName("inbound_pending")]
        public long InboundPending { get; set; }

        /// <summary>
        /// The change made to funds in the account, but not spendable because they are being held
        /// for pending outbound flows.
        /// </summary>
        [JsonPropertyName("outbound_pending")]
        public long OutboundPending { get; set; }
    }
}
