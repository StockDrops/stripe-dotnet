// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodOptionsAcssDebit : StripeEntity<SetupIntentPaymentMethodOptionsAcssDebit>
    {
        /// <summary>
        /// Currency supported by the bank account.
        /// One of: <c>cad</c>, or <c>usd</c>.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("mandate_options")]
        public SetupIntentPaymentMethodOptionsAcssDebitMandateOptions MandateOptions { get; set; }

        /// <summary>
        /// Bank account verification method.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonPropertyName("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
