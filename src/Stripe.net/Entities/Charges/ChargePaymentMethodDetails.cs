// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetails : StripeEntity<ChargePaymentMethodDetails>
    {
        [JsonPropertyName("ach_credit_transfer")]
        public ChargePaymentMethodDetailsAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonPropertyName("ach_debit")]
        public ChargePaymentMethodDetailsAchDebit AchDebit { get; set; }

        [JsonPropertyName("acss_debit")]
        public ChargePaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonPropertyName("affirm")]
        public ChargePaymentMethodDetailsAffirm Affirm { get; set; }

        [JsonPropertyName("afterpay_clearpay")]
        public ChargePaymentMethodDetailsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonPropertyName("alipay")]
        public ChargePaymentMethodDetailsAlipay Alipay { get; set; }

        [JsonPropertyName("au_becs_debit")]
        public ChargePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonPropertyName("bacs_debit")]
        public ChargePaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonPropertyName("bancontact")]
        public ChargePaymentMethodDetailsBancontact Bancontact { get; set; }

        [JsonPropertyName("blik")]
        public ChargePaymentMethodDetailsBlik Blik { get; set; }

        [JsonPropertyName("boleto")]
        public ChargePaymentMethodDetailsBoleto Boleto { get; set; }

        [JsonPropertyName("card")]
        public ChargePaymentMethodDetailsCard Card { get; set; }

        [JsonPropertyName("card_present")]
        public ChargePaymentMethodDetailsCardPresent CardPresent { get; set; }

        [JsonPropertyName("customer_balance")]
        public ChargePaymentMethodDetailsCustomerBalance CustomerBalance { get; set; }

        [JsonPropertyName("eps")]
        public ChargePaymentMethodDetailsEps Eps { get; set; }

        [JsonPropertyName("fpx")]
        public ChargePaymentMethodDetailsFpx Fpx { get; set; }

        [JsonPropertyName("giropay")]
        public ChargePaymentMethodDetailsGiropay Giropay { get; set; }

        [JsonPropertyName("grabpay")]
        public ChargePaymentMethodDetailsGrabpay Grabpay { get; set; }

        [JsonPropertyName("ideal")]
        public ChargePaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonPropertyName("interac_present")]
        public ChargePaymentMethodDetailsInteracPresent InteracPresent { get; set; }

        [JsonPropertyName("klarna")]
        public ChargePaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonPropertyName("konbini")]
        public ChargePaymentMethodDetailsKonbini Konbini { get; set; }

        [JsonPropertyName("link")]
        public ChargePaymentMethodDetailsLink Link { get; set; }

        [JsonPropertyName("multibanco")]
        public ChargePaymentMethodDetailsMultibanco Multibanco { get; set; }

        [JsonPropertyName("oxxo")]
        public ChargePaymentMethodDetailsOxxo Oxxo { get; set; }

        [JsonPropertyName("p24")]
        public ChargePaymentMethodDetailsP24 P24 { get; set; }

        [JsonPropertyName("paynow")]
        public ChargePaymentMethodDetailsPaynow Paynow { get; set; }

        [JsonPropertyName("promptpay")]
        public ChargePaymentMethodDetailsPromptpay Promptpay { get; set; }

        [JsonPropertyName("sepa_debit")]
        public ChargePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonPropertyName("sofort")]
        public ChargePaymentMethodDetailsSofort Sofort { get; set; }

        [JsonPropertyName("stripe_account")]
        public ChargePaymentMethodDetailsStripeAccount StripeAccount { get; set; }

        /// <summary>
        /// The type of transaction-specific details of the payment method used in the payment, one
        /// of <c>ach_credit_transfer</c>, <c>ach_debit</c>, <c>acss_debit</c>, <c>alipay</c>,
        /// <c>au_becs_debit</c>, <c>bancontact</c>, <c>card</c>, <c>card_present</c>, <c>eps</c>,
        /// <c>giropay</c>, <c>ideal</c>, <c>klarna</c>, <c>multibanco</c>, <c>p24</c>,
        /// <c>sepa_debit</c>, <c>sofort</c>, <c>stripe_account</c>, or <c>wechat</c>. An additional
        /// hash is included on <c>payment_method_details</c> with a name matching this value. It
        /// contains information specific to the payment method.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("us_bank_account")]
        public ChargePaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }

        [JsonPropertyName("wechat")]
        public ChargePaymentMethodDetailsWechat Wechat { get; set; }

        [JsonPropertyName("wechat_pay")]
        public ChargePaymentMethodDetailsWechatPay WechatPay { get; set; }
    }
}
