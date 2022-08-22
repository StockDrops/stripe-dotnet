// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// If this is an <c>acss_debit</c> PaymentMethod, this hash contains details about the ACSS
        /// Debit payment method.
        /// </summary>
        [JsonPropertyName("acss_debit")]
        public SetupIntentPaymentMethodDataAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// If this is an <c>affirm</c> PaymentMethod, this hash contains details about the Affirm
        /// payment method.
        /// </summary>
        [JsonPropertyName("affirm")]
        public SetupIntentPaymentMethodDataAffirmOptions Affirm { get; set; }

        /// <summary>
        /// If this is an <c>AfterpayClearpay</c> PaymentMethod, this hash contains details about
        /// the AfterpayClearpay payment method.
        /// </summary>
        [JsonPropertyName("afterpay_clearpay")]
        public SetupIntentPaymentMethodDataAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// If this is an <c>Alipay</c> PaymentMethod, this hash contains details about the Alipay
        /// payment method.
        /// </summary>
        [JsonPropertyName("alipay")]
        public SetupIntentPaymentMethodDataAlipayOptions Alipay { get; set; }

        /// <summary>
        /// If this is an <c>au_becs_debit</c> PaymentMethod, this hash contains details about the
        /// bank account.
        /// </summary>
        [JsonPropertyName("au_becs_debit")]
        public SetupIntentPaymentMethodDataAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bacs_debit</c> PaymentMethod, this hash contains details about the Bacs
        /// Direct Debit bank account.
        /// </summary>
        [JsonPropertyName("bacs_debit")]
        public SetupIntentPaymentMethodDataBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bancontact</c> PaymentMethod, this hash contains details about the
        /// Bancontact payment method.
        /// </summary>
        [JsonPropertyName("bancontact")]
        public SetupIntentPaymentMethodDataBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonPropertyName("billing_details")]
        public SetupIntentPaymentMethodDataBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// If this is a <c>blik</c> PaymentMethod, this hash contains details about the BLIK
        /// payment method.
        /// </summary>
        [JsonPropertyName("blik")]
        public SetupIntentPaymentMethodDataBlikOptions Blik { get; set; }

        /// <summary>
        /// If this is a <c>boleto</c> PaymentMethod, this hash contains details about the Boleto
        /// payment method.
        /// </summary>
        [JsonPropertyName("boleto")]
        public SetupIntentPaymentMethodDataBoletoOptions Boleto { get; set; }

        /// <summary>
        /// If this is a <c>customer_balance</c> PaymentMethod, this hash contains details about the
        /// CustomerBalance payment method.
        /// </summary>
        [JsonPropertyName("customer_balance")]
        public SetupIntentPaymentMethodDataCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// If this is an <c>eps</c> PaymentMethod, this hash contains details about the EPS payment
        /// method.
        /// </summary>
        [JsonPropertyName("eps")]
        public SetupIntentPaymentMethodDataEpsOptions Eps { get; set; }

        /// <summary>
        /// If this is an <c>fpx</c> PaymentMethod, this hash contains details about the FPX payment
        /// method.
        /// </summary>
        [JsonPropertyName("fpx")]
        public SetupIntentPaymentMethodDataFpxOptions Fpx { get; set; }

        /// <summary>
        /// If this is a <c>giropay</c> PaymentMethod, this hash contains details about the Giropay
        /// payment method.
        /// </summary>
        [JsonPropertyName("giropay")]
        public SetupIntentPaymentMethodDataGiropayOptions Giropay { get; set; }

        /// <summary>
        /// If this is a <c>grabpay</c> PaymentMethod, this hash contains details about the GrabPay
        /// payment method.
        /// </summary>
        [JsonPropertyName("grabpay")]
        public SetupIntentPaymentMethodDataGrabpayOptions Grabpay { get; set; }

        /// <summary>
        /// If this is an <c>ideal</c> PaymentMethod, this hash contains details about the iDEAL
        /// payment method.
        /// </summary>
        [JsonPropertyName("ideal")]
        public SetupIntentPaymentMethodDataIdealOptions Ideal { get; set; }

        /// <summary>
        /// If this is an <c>interac_present</c> PaymentMethod, this hash contains details about the
        /// Interac Present payment method.
        /// </summary>
        [JsonPropertyName("interac_present")]
        public SetupIntentPaymentMethodDataInteracPresentOptions InteracPresent { get; set; }

        /// <summary>
        /// If this is a <c>klarna</c> PaymentMethod, this hash contains details about the Klarna
        /// payment method.
        /// </summary>
        [JsonPropertyName("klarna")]
        public SetupIntentPaymentMethodDataKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// If this is a <c>konbini</c> PaymentMethod, this hash contains details about the Konbini
        /// payment method.
        /// </summary>
        [JsonPropertyName("konbini")]
        public SetupIntentPaymentMethodDataKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// If this is an <c>Link</c> PaymentMethod, this hash contains details about the Link
        /// payment method.
        /// </summary>
        [JsonPropertyName("link")]
        public SetupIntentPaymentMethodDataLinkOptions Link { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If this is an <c>oxxo</c> PaymentMethod, this hash contains details about the OXXO
        /// payment method.
        /// </summary>
        [JsonPropertyName("oxxo")]
        public SetupIntentPaymentMethodDataOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// If this is a <c>p24</c> PaymentMethod, this hash contains details about the P24 payment
        /// method.
        /// </summary>
        [JsonPropertyName("p24")]
        public SetupIntentPaymentMethodDataP24Options P24 { get; set; }

        /// <summary>
        /// If this is a <c>paynow</c> PaymentMethod, this hash contains details about the PayNow
        /// payment method.
        /// </summary>
        [JsonPropertyName("paynow")]
        public SetupIntentPaymentMethodDataPaynowOptions Paynow { get; set; }

        /// <summary>
        /// If this is a <c>promptpay</c> PaymentMethod, this hash contains details about the
        /// PromptPay payment method.
        /// </summary>
        [JsonPropertyName("promptpay")]
        public SetupIntentPaymentMethodDataPromptpayOptions Promptpay { get; set; }

        /// <summary>
        /// Options to configure Radar. See <a
        /// href="https://stripe.com/docs/radar/radar-session">Radar Session</a> for more
        /// information.
        /// </summary>
        [JsonPropertyName("radar_options")]
        public SetupIntentPaymentMethodDataRadarOptionsOptions RadarOptions { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> PaymentMethod, this hash contains details about the SEPA
        /// debit bank account.
        /// </summary>
        [JsonPropertyName("sepa_debit")]
        public SetupIntentPaymentMethodDataSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// If this is a <c>sofort</c> PaymentMethod, this hash contains details about the SOFORT
        /// payment method.
        /// </summary>
        [JsonPropertyName("sofort")]
        public SetupIntentPaymentMethodDataSofortOptions Sofort { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>, <c>blik</c>, <c>boleto</c>,
        /// <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>grabpay</c>,
        /// <c>ideal</c>, <c>klarna</c>, <c>konbini</c>, <c>link</c>, <c>oxxo</c>, <c>p24</c>,
        /// <c>paynow</c>, <c>promptpay</c>, <c>sepa_debit</c>, <c>sofort</c>,
        /// <c>us_bank_account</c>, or <c>wechat_pay</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// If this is an <c>us_bank_account</c> PaymentMethod, this hash contains details about the
        /// US bank account payment method.
        /// </summary>
        [JsonPropertyName("us_bank_account")]
        public SetupIntentPaymentMethodDataUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// If this is an <c>wechat_pay</c> PaymentMethod, this hash contains details about the
        /// wechat_pay payment method.
        /// </summary>
        [JsonPropertyName("wechat_pay")]
        public SetupIntentPaymentMethodDataWechatPayOptions WechatPay { get; set; }
    }
}
