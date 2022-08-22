// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountFeaturesOutboundPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH transfers via the OutboundPayments API.
        /// </summary>
        [JsonPropertyName("ach")]
        public FinancialAccountFeaturesOutboundPaymentsAchOptions Ach { get; set; }

        /// <summary>
        /// Enables US domestic wire tranfers via the OutboundPayments API.
        /// </summary>
        [JsonPropertyName("us_domestic_wire")]
        public FinancialAccountFeaturesOutboundPaymentsUsDomesticWireOptions UsDomesticWire { get; set; }
    }
}
