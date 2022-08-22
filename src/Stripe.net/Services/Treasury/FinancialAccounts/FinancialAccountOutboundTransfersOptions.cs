// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountOutboundTransfersOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH transfers via the OutboundTransfers API.
        /// </summary>
        [JsonPropertyName("ach")]
        public FinancialAccountOutboundTransfersAchOptions Ach { get; set; }

        /// <summary>
        /// Enables US domestic wire tranfers via the OutboundTransfers API.
        /// </summary>
        [JsonPropertyName("us_domestic_wire")]
        public FinancialAccountOutboundTransfersUsDomesticWireOptions UsDomesticWire { get; set; }
    }
}
