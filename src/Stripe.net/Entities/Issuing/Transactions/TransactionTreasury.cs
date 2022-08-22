// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class TransactionTreasury : StripeEntity<TransactionTreasury>
    {
        /// <summary>
        /// The Treasury <a
        /// href="https://stripe.com/docs/api/treasury/received_debits">ReceivedCredit</a>
        /// representing this Issuing transaction if it is a refund.
        /// </summary>
        [JsonPropertyName("received_credit")]
        public string ReceivedCredit { get; set; }

        /// <summary>
        /// The Treasury <a
        /// href="https://stripe.com/docs/api/treasury/received_credits">ReceivedDebit</a>
        /// representing this Issuing transaction if it is a capture.
        /// </summary>
        [JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }
    }
}
