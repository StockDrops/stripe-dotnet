// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class MandatePaymentMethodDetails : StripeEntity<MandatePaymentMethodDetails>
    {
        [JsonPropertyName("acss_debit")]
        public MandatePaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonPropertyName("au_becs_debit")]
        public MandatePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonPropertyName("bacs_debit")]
        public MandatePaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonPropertyName("blik")]
        public MandatePaymentMethodDetailsBlik Blik { get; set; }

        [JsonPropertyName("card")]
        public MandatePaymentMethodDetailsCard Card { get; set; }

        [JsonPropertyName("link")]
        public MandatePaymentMethodDetailsLink Link { get; set; }

        [JsonPropertyName("sepa_debit")]
        public MandatePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// The type of the payment method associated with this mandate. An additional hash is
        /// included on <c>payment_method_details</c> with a name matching this value. It contains
        /// mandate information specific to the payment method.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("us_bank_account")]
        public MandatePaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
