// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountFeaturesOutboundPayments : StripeEntity<FinancialAccountFeaturesOutboundPayments>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonPropertyName("ach")]
        public FinancialAccountFeaturesOutboundPaymentsAch Ach { get; set; }

        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonPropertyName("us_domestic_wire")]
        public FinancialAccountFeaturesOutboundPaymentsUsDomesticWire UsDomesticWire { get; set; }
    }
}
