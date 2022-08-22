// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupAttemptPaymentMethodDetails : StripeEntity<SetupAttemptPaymentMethodDetails>
    {
        [JsonPropertyName("acss_debit")]
        public SetupAttemptPaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonPropertyName("au_becs_debit")]
        public SetupAttemptPaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonPropertyName("bacs_debit")]
        public SetupAttemptPaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonPropertyName("bancontact")]
        public SetupAttemptPaymentMethodDetailsBancontact Bancontact { get; set; }

        [JsonPropertyName("blik")]
        public SetupAttemptPaymentMethodDetailsBlik Blik { get; set; }

        [JsonPropertyName("boleto")]
        public SetupAttemptPaymentMethodDetailsBoleto Boleto { get; set; }

        [JsonPropertyName("card")]
        public SetupAttemptPaymentMethodDetailsCard Card { get; set; }

        [JsonPropertyName("card_present")]
        public SetupAttemptPaymentMethodDetailsCardPresent CardPresent { get; set; }

        [JsonPropertyName("ideal")]
        public SetupAttemptPaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonPropertyName("link")]
        public SetupAttemptPaymentMethodDetailsLink Link { get; set; }

        [JsonPropertyName("sepa_debit")]
        public SetupAttemptPaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonPropertyName("sofort")]
        public SetupAttemptPaymentMethodDetailsSofort Sofort { get; set; }

        /// <summary>
        /// The type of the payment method used in the SetupIntent (e.g., <c>card</c>). An
        /// additional hash is included on <c>payment_method_details</c> with a name matching this
        /// value. It contains confirmation-specific information for the payment method.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("us_bank_account")]
        public SetupAttemptPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
