// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountFeaturesOutboundTransfers : StripeEntity<FinancialAccountFeaturesOutboundTransfers>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonPropertyName("ach")]
        public FinancialAccountFeaturesOutboundTransfersAch Ach { get; set; }

        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonPropertyName("us_domestic_wire")]
        public FinancialAccountFeaturesOutboundTransfersUsDomesticWire UsDomesticWire { get; set; }
    }
}
