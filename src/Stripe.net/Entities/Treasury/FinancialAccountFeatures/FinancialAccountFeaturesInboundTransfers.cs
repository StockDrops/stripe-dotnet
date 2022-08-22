// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountFeaturesInboundTransfers : StripeEntity<FinancialAccountFeaturesInboundTransfers>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonPropertyName("ach")]
        public FinancialAccountFeaturesInboundTransfersAch Ach { get; set; }
    }
}
