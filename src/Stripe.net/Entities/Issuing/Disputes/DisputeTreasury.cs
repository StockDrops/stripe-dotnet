// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class DisputeTreasury : StripeEntity<DisputeTreasury>
    {
        /// <summary>
        /// The Treasury <a
        /// href="https://stripe.com/docs/api/treasury/debit_reversals">DebitReversal</a>
        /// representing this Issuing dispute.
        /// </summary>
        [JsonPropertyName("debit_reversal")]
        public string DebitReversal { get; set; }

        /// <summary>
        /// The Treasury <a
        /// href="https://stripe.com/docs/api/treasury/received_debits">ReceivedDebit</a> that is
        /// being disputed.
        /// </summary>
        [JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }
    }
}
