// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class DebitReversalLinkedFlows : StripeEntity<DebitReversalLinkedFlows>
    {
        /// <summary>
        /// Set if there is an Issuing dispute associated with the DebitReversal.
        /// </summary>
        [JsonPropertyName("issuing_dispute")]
        public string IssuingDispute { get; set; }
    }
}
