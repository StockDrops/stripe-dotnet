// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountFeaturesFinancialAddressesOptions : INestedOptions
    {
        /// <summary>
        /// Adds an ABA FinancialAddress to the FinancialAccount.
        /// </summary>
        [JsonPropertyName("aba")]
        public FinancialAccountFeaturesFinancialAddressesAbaOptions Aba { get; set; }
    }
}
