// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class ReceivedCreditLinkedFlows : StripeEntity<ReceivedCreditLinkedFlows>
    {
        /// <summary>
        /// The CreditReversal created as a result of this ReceivedCredit being reversed.
        /// </summary>
        [JsonPropertyName("credit_reversal")]
        public string CreditReversal { get; set; }

        /// <summary>
        /// Set if the ReceivedCredit was created due to an <a
        /// href="https://stripe.com/docs/api#issuing_authorizations">Issuing Authorization</a>
        /// object.
        /// </summary>
        [JsonPropertyName("issuing_authorization")]
        public string IssuingAuthorization { get; set; }

        /// <summary>
        /// Set if the ReceivedCredit is also viewable as an <a
        /// href="https://stripe.com/docs/api#issuing_transactions">Issuing transaction</a> object.
        /// </summary>
        [JsonPropertyName("issuing_transaction")]
        public string IssuingTransaction { get; set; }

        /// <summary>
        /// ID of the source flow. Set if <c>network</c> is <c>stripe</c> and the source flow is
        /// visible to the user. Examples of source flows include OutboundPayments, payouts, or
        /// CreditReversals.
        /// </summary>
        [JsonPropertyName("source_flow")]
        public string SourceFlow { get; set; }

        /// <summary>
        /// The expandable object of the source flow.
        /// </summary>
        [JsonPropertyName("source_flow_details")]
        public ReceivedCreditLinkedFlowsSourceFlowDetails SourceFlowDetails { get; set; }

        /// <summary>
        /// The type of flow that originated the ReceivedCredit (for example,
        /// <c>outbound_payment</c>).
        /// </summary>
        [JsonPropertyName("source_flow_type")]
        public string SourceFlowType { get; set; }
    }
}
