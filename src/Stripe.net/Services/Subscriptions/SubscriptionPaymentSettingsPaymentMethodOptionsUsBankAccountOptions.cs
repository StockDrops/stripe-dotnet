// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// Additional fields for Financial Connections Session creation.
        /// </summary>
        [JsonPropertyName("financial_connections")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions FinancialConnections { get; set; }

        /// <summary>
        /// Verification method for the intent.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonPropertyName("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
