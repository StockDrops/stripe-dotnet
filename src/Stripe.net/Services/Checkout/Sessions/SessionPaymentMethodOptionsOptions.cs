// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// contains details about the ACSS Debit payment method options.
        /// </summary>
        [JsonPropertyName("acss_debit")]
        public SessionPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// contains details about the Affirm payment method options.
        /// </summary>
        [JsonPropertyName("affirm")]
        public SessionPaymentMethodOptionsAffirmOptions Affirm { get; set; }

        /// <summary>
        /// contains details about the Afterpay Clearpay payment method options.
        /// </summary>
        [JsonPropertyName("afterpay_clearpay")]
        public SessionPaymentMethodOptionsAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// contains details about the Alipay payment method options.
        /// </summary>
        [JsonPropertyName("alipay")]
        public SessionPaymentMethodOptionsAlipayOptions Alipay { get; set; }

        /// <summary>
        /// contains details about the AU Becs Debit payment method options.
        /// </summary>
        [JsonPropertyName("au_becs_debit")]
        public SessionPaymentMethodOptionsAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// contains details about the Bacs Debit payment method options.
        /// </summary>
        [JsonPropertyName("bacs_debit")]
        public SessionPaymentMethodOptionsBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// contains details about the Bancontact payment method options.
        /// </summary>
        [JsonPropertyName("bancontact")]
        public SessionPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// contains details about the Boleto payment method options.
        /// </summary>
        [JsonPropertyName("boleto")]
        public SessionPaymentMethodOptionsBoletoOptions Boleto { get; set; }

        /// <summary>
        /// contains details about the Card payment method options.
        /// </summary>
        [JsonPropertyName("card")]
        public SessionPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// contains details about the Customer Balance payment method options.
        /// </summary>
        [JsonPropertyName("customer_balance")]
        public SessionPaymentMethodOptionsCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// contains details about the EPS payment method options.
        /// </summary>
        [JsonPropertyName("eps")]
        public SessionPaymentMethodOptionsEpsOptions Eps { get; set; }

        /// <summary>
        /// contains details about the EPS payment method options.
        /// </summary>
        [JsonPropertyName("fpx")]
        public SessionPaymentMethodOptionsFpxOptions Fpx { get; set; }

        /// <summary>
        /// contains details about the Giropay payment method options.
        /// </summary>
        [JsonPropertyName("giropay")]
        public SessionPaymentMethodOptionsGiropayOptions Giropay { get; set; }

        /// <summary>
        /// contains details about the Grabpay payment method options.
        /// </summary>
        [JsonPropertyName("grabpay")]
        public SessionPaymentMethodOptionsGrabpayOptions Grabpay { get; set; }

        /// <summary>
        /// contains details about the Ideal payment method options.
        /// </summary>
        [JsonPropertyName("ideal")]
        public SessionPaymentMethodOptionsIdealOptions Ideal { get; set; }

        /// <summary>
        /// contains details about the Klarna payment method options.
        /// </summary>
        [JsonPropertyName("klarna")]
        public SessionPaymentMethodOptionsKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// contains details about the Konbini payment method options.
        /// </summary>
        [JsonPropertyName("konbini")]
        public SessionPaymentMethodOptionsKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// contains details about the OXXO payment method options.
        /// </summary>
        [JsonPropertyName("oxxo")]
        public SessionPaymentMethodOptionsOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// contains details about the P24 payment method options.
        /// </summary>
        [JsonPropertyName("p24")]
        public SessionPaymentMethodOptionsP24Options P24 { get; set; }

        /// <summary>
        /// contains details about the PayNow payment method options.
        /// </summary>
        [JsonPropertyName("paynow")]
        public SessionPaymentMethodOptionsPaynowOptions Paynow { get; set; }

        /// <summary>
        /// contains details about the Sepa Debit payment method options.
        /// </summary>
        [JsonPropertyName("sepa_debit")]
        public SessionPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// contains details about the Sofort payment method options.
        /// </summary>
        [JsonPropertyName("sofort")]
        public SessionPaymentMethodOptionsSofortOptions Sofort { get; set; }

        /// <summary>
        /// contains details about the Us Bank Account payment method options.
        /// </summary>
        [JsonPropertyName("us_bank_account")]
        public SessionPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// contains details about the WeChat Pay payment method options.
        /// </summary>
        [JsonPropertyName("wechat_pay")]
        public SessionPaymentMethodOptionsWechatPayOptions WechatPay { get; set; }
    }
}
