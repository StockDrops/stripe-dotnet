// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionPaymentMethodOptions : StripeEntity<SessionPaymentMethodOptions>
    {
        [JsonPropertyName("acss_debit")]
        public SessionPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonPropertyName("affirm")]
        public SessionPaymentMethodOptionsAffirm Affirm { get; set; }

        [JsonPropertyName("afterpay_clearpay")]
        public SessionPaymentMethodOptionsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonPropertyName("alipay")]
        public SessionPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonPropertyName("au_becs_debit")]
        public SessionPaymentMethodOptionsAuBecsDebit AuBecsDebit { get; set; }

        [JsonPropertyName("bacs_debit")]
        public SessionPaymentMethodOptionsBacsDebit BacsDebit { get; set; }

        [JsonPropertyName("bancontact")]
        public SessionPaymentMethodOptionsBancontact Bancontact { get; set; }

        [JsonPropertyName("boleto")]
        public SessionPaymentMethodOptionsBoleto Boleto { get; set; }

        [JsonPropertyName("card")]
        public SessionPaymentMethodOptionsCard Card { get; set; }

        [JsonPropertyName("customer_balance")]
        public SessionPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        [JsonPropertyName("eps")]
        public SessionPaymentMethodOptionsEps Eps { get; set; }

        [JsonPropertyName("fpx")]
        public SessionPaymentMethodOptionsFpx Fpx { get; set; }

        [JsonPropertyName("giropay")]
        public SessionPaymentMethodOptionsGiropay Giropay { get; set; }

        [JsonPropertyName("grabpay")]
        public SessionPaymentMethodOptionsGrabpay Grabpay { get; set; }

        [JsonPropertyName("ideal")]
        public SessionPaymentMethodOptionsIdeal Ideal { get; set; }

        [JsonPropertyName("klarna")]
        public SessionPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonPropertyName("konbini")]
        public SessionPaymentMethodOptionsKonbini Konbini { get; set; }

        [JsonPropertyName("oxxo")]
        public SessionPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonPropertyName("p24")]
        public SessionPaymentMethodOptionsP24 P24 { get; set; }

        [JsonPropertyName("paynow")]
        public SessionPaymentMethodOptionsPaynow Paynow { get; set; }

        [JsonPropertyName("sepa_debit")]
        public SessionPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonPropertyName("sofort")]
        public SessionPaymentMethodOptionsSofort Sofort { get; set; }

        [JsonPropertyName("us_bank_account")]
        public SessionPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
