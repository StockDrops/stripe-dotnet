// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class InvoicePaymentSettingsPaymentMethodOptions : StripeEntity<InvoicePaymentSettingsPaymentMethodOptions>
    {
        /// <summary>
        /// If paying by <c>acss_debit</c>, this sub-hash contains details about the Canadian
        /// pre-authorized debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonPropertyName("acss_debit")]
        public InvoicePaymentSettingsPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// If paying by <c>bancontact</c>, this sub-hash contains details about the Bancontact
        /// payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonPropertyName("bancontact")]
        public InvoicePaymentSettingsPaymentMethodOptionsBancontact Bancontact { get; set; }

        /// <summary>
        /// If paying by <c>card</c>, this sub-hash contains details about the Card payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonPropertyName("card")]
        public InvoicePaymentSettingsPaymentMethodOptionsCard Card { get; set; }

        /// <summary>
        /// If paying by <c>customer_balance</c>, this sub-hash contains details about the Bank
        /// transfer payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonPropertyName("customer_balance")]
        public InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        /// <summary>
        /// If paying by <c>konbini</c>, this sub-hash contains details about the Konbini payment
        /// method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonPropertyName("konbini")]
        public InvoicePaymentSettingsPaymentMethodOptionsKonbini Konbini { get; set; }

        /// <summary>
        /// If paying by <c>us_bank_account</c>, this sub-hash contains details about the ACH direct
        /// debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonPropertyName("us_bank_account")]
        public InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
