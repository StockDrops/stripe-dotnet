// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class InvoicePaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions>
    {
        /// <summary>
        /// Transaction type of the mandate.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonPropertyName("transaction_type")]
        public string TransactionType { get; set; }
    }
}
