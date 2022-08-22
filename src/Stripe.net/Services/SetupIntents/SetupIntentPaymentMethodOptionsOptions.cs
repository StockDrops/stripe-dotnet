// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// If this is a <c>acss_debit</c> SetupIntent, this sub-hash contains details about the
        /// ACSS Debit payment method options.
        /// </summary>
        [JsonPropertyName("acss_debit")]
        public SetupIntentPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// If this is a <c>blik</c> PaymentMethod, this hash contains details about the BLIK
        /// payment method.
        /// </summary>
        [JsonPropertyName("blik")]
        public SetupIntentPaymentMethodOptionsBlikOptions Blik { get; set; }

        /// <summary>
        /// Configuration for any card setup attempted on this SetupIntent.
        /// </summary>
        [JsonPropertyName("card")]
        public SetupIntentPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// If this is a <c>link</c> PaymentMethod, this sub-hash contains details about the Link
        /// payment method options.
        /// </summary>
        [JsonPropertyName("link")]
        public SetupIntentPaymentMethodOptionsLinkOptions Link { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> SetupIntent, this sub-hash contains details about the
        /// SEPA Debit payment method options.
        /// </summary>
        [JsonPropertyName("sepa_debit")]
        public SetupIntentPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// If this is a <c>us_bank_account</c> SetupIntent, this sub-hash contains details about
        /// the US bank account payment method options.
        /// </summary>
        [JsonPropertyName("us_bank_account")]
        public SetupIntentPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
