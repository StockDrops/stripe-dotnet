// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodOptions : StripeEntity<SetupIntentPaymentMethodOptions>
    {
        [JsonPropertyName("acss_debit")]
        public SetupIntentPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonPropertyName("blik")]
        public SetupIntentPaymentMethodOptionsBlik Blik { get; set; }

        [JsonPropertyName("card")]
        public SetupIntentPaymentMethodOptionsCard Card { get; set; }

        [JsonPropertyName("link")]
        public SetupIntentPaymentMethodOptionsLink Link { get; set; }

        [JsonPropertyName("sepa_debit")]
        public SetupIntentPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonPropertyName("us_bank_account")]
        public SetupIntentPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
