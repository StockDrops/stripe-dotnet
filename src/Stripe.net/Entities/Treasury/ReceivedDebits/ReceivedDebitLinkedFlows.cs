// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class ReceivedDebitLinkedFlows : StripeEntity<ReceivedDebitLinkedFlows>
    {
        /// <summary>
        /// The DebitReversal created as a result of this ReceivedDebit being reversed.
        /// </summary>
        [JsonPropertyName("debit_reversal")]
        public string DebitReversal { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit is associated with an InboundTransfer's return of funds.
        /// </summary>
        [JsonPropertyName("inbound_transfer")]
        public string InboundTransfer { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit was created due to an <a
        /// href="https://stripe.com/docs/api#issuing_authorizations">Issuing Authorization</a>
        /// object.
        /// </summary>
        [JsonPropertyName("issuing_authorization")]
        public string IssuingAuthorization { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit is also viewable as an <a
        /// href="https://stripe.com/docs/api#issuing_disputes">Issuing Dispute</a> object.
        /// </summary>
        [JsonPropertyName("issuing_transaction")]
        public string IssuingTransaction { get; set; }
    }
}
