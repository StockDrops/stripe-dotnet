// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentPaymentMethodOptions : StripeEntity<PaymentIntentPaymentMethodOptions>
    {
        [JsonPropertyName("acss_debit")]
        public PaymentIntentPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonPropertyName("affirm")]
        public PaymentIntentPaymentMethodOptionsAffirm Affirm { get; set; }

        [JsonPropertyName("afterpay_clearpay")]
        public PaymentIntentPaymentMethodOptionsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonPropertyName("alipay")]
        public PaymentIntentPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonPropertyName("au_becs_debit")]
        public PaymentIntentPaymentMethodOptionsAuBecsDebit AuBecsDebit { get; set; }

        [JsonPropertyName("bacs_debit")]
        public PaymentIntentPaymentMethodOptionsBacsDebit BacsDebit { get; set; }

        [JsonPropertyName("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontact Bancontact { get; set; }

        [JsonPropertyName("blik")]
        public PaymentIntentPaymentMethodOptionsBlik Blik { get; set; }

        [JsonPropertyName("boleto")]
        public PaymentIntentPaymentMethodOptionsBoleto Boleto { get; set; }

        [JsonPropertyName("card")]
        public PaymentIntentPaymentMethodOptionsCard Card { get; set; }

        [JsonPropertyName("card_present")]
        public PaymentIntentPaymentMethodOptionsCardPresent CardPresent { get; set; }

        [JsonPropertyName("customer_balance")]
        public PaymentIntentPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        [JsonPropertyName("eps")]
        public PaymentIntentPaymentMethodOptionsEps Eps { get; set; }

        [JsonPropertyName("fpx")]
        public PaymentIntentPaymentMethodOptionsFpx Fpx { get; set; }

        [JsonPropertyName("giropay")]
        public PaymentIntentPaymentMethodOptionsGiropay Giropay { get; set; }

        [JsonPropertyName("grabpay")]
        public PaymentIntentPaymentMethodOptionsGrabpay Grabpay { get; set; }

        [JsonPropertyName("ideal")]
        public PaymentIntentPaymentMethodOptionsIdeal Ideal { get; set; }

        [JsonPropertyName("interac_present")]
        public PaymentIntentPaymentMethodOptionsInteracPresent InteracPresent { get; set; }

        [JsonPropertyName("klarna")]
        public PaymentIntentPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonPropertyName("konbini")]
        public PaymentIntentPaymentMethodOptionsKonbini Konbini { get; set; }

        [JsonPropertyName("link")]
        public PaymentIntentPaymentMethodOptionsLink Link { get; set; }

        [JsonPropertyName("oxxo")]
        public PaymentIntentPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonPropertyName("p24")]
        public PaymentIntentPaymentMethodOptionsP24 P24 { get; set; }

        [JsonPropertyName("paynow")]
        public PaymentIntentPaymentMethodOptionsPaynow Paynow { get; set; }

        [JsonPropertyName("promptpay")]
        public PaymentIntentPaymentMethodOptionsPromptpay Promptpay { get; set; }

        [JsonPropertyName("sepa_debit")]
        public PaymentIntentPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonPropertyName("sofort")]
        public PaymentIntentPaymentMethodOptionsSofort Sofort { get; set; }

        [JsonPropertyName("us_bank_account")]
        public PaymentIntentPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }

        [JsonPropertyName("wechat_pay")]
        public PaymentIntentPaymentMethodOptionsWechatPay WechatPay { get; set; }
    }
}
