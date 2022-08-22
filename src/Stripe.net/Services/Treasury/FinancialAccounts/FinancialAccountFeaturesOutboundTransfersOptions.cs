// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountFeaturesOutboundTransfersOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH transfers via the OutboundTransfers API.
        /// </summary>
        [JsonPropertyName("ach")]
        public FinancialAccountFeaturesOutboundTransfersAchOptions Ach { get; set; }

        /// <summary>
        /// Enables US domestic wire tranfers via the OutboundTransfers API.
        /// </summary>
        [JsonPropertyName("us_domestic_wire")]
        public FinancialAccountFeaturesOutboundTransfersUsDomesticWireOptions UsDomesticWire { get; set; }
    }
}
