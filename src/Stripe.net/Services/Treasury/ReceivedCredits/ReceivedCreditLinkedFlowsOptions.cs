// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class ReceivedCreditLinkedFlowsOptions : INestedOptions
    {
        /// <summary>
        /// The source flow type.
        /// One of: <c>credit_reversal</c>, <c>other</c>, <c>outbound_payment</c>, or <c>payout</c>.
        /// </summary>
        [JsonPropertyName("source_flow_type")]
        public string SourceFlowType { get; set; }
    }
}
