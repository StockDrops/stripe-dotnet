// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountFeaturesFinancialAddresses : StripeEntity<FinancialAccountFeaturesFinancialAddresses>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonPropertyName("aba")]
        public FinancialAccountFeaturesFinancialAddressesAba Aba { get; set; }
    }
}
