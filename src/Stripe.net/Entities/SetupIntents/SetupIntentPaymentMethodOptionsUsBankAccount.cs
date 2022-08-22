// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodOptionsUsBankAccount : StripeEntity<SetupIntentPaymentMethodOptionsUsBankAccount>
    {
        [JsonPropertyName("financial_connections")]
        public SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections FinancialConnections { get; set; }

        /// <summary>
        /// Bank account verification method.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonPropertyName("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
