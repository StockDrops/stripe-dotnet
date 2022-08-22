// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class InvoicePaymentSettingsPaymentMethodOptionsAcssDebit : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsAcssDebit>
    {
        [JsonPropertyName("mandate_options")]
        public InvoicePaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions MandateOptions { get; set; }

        /// <summary>
        /// Bank account verification method.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonPropertyName("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
