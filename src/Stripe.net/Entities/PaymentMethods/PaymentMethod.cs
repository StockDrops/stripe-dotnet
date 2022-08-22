// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// PaymentMethod objects represent your customer's payment instruments. You can use them
    /// with <a href="https://stripe.com/docs/payments/payment-intents">PaymentIntents</a> to
    /// collect payments or save them to Customer objects to store instrument details for future
    /// payments.
    ///
    /// Related guides: <a href="https://stripe.com/docs/payments/payment-methods">Payment
    /// Methods</a> and <a href="https://stripe.com/docs/payments/more-payment-scenarios">More
    /// Payment Scenarios</a>.
    /// </summary>
    public class PaymentMethod : StripeEntity<PaymentMethod>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("acss_debit")]
        public PaymentMethodAcssDebit AcssDebit { get; set; }

        [JsonPropertyName("affirm")]
        public PaymentMethodAffirm Affirm { get; set; }

        [JsonPropertyName("afterpay_clearpay")]
        public PaymentMethodAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonPropertyName("alipay")]
        public PaymentMethodAlipay Alipay { get; set; }

        [JsonPropertyName("au_becs_debit")]
        public PaymentMethodAuBecsDebit AuBecsDebit { get; set; }

        [JsonPropertyName("bacs_debit")]
        public PaymentMethodBacsDebit BacsDebit { get; set; }

        [JsonPropertyName("bancontact")]
        public PaymentMethodBancontact Bancontact { get; set; }

        [JsonPropertyName("billing_details")]
        public PaymentMethodBillingDetails BillingDetails { get; set; }

        [JsonPropertyName("blik")]
        public PaymentMethodBlik Blik { get; set; }

        [JsonPropertyName("boleto")]
        public PaymentMethodBoleto Boleto { get; set; }

        [JsonPropertyName("card")]
        public PaymentMethodCard Card { get; set; }

        [JsonPropertyName("card_present")]
        public PaymentMethodCardPresent CardPresent { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonPropertyName("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonPropertyName("customer_balance")]
        public PaymentMethodCustomerBalance CustomerBalance { get; set; }

        [JsonPropertyName("eps")]
        public PaymentMethodEps Eps { get; set; }

        [JsonPropertyName("fpx")]
        public PaymentMethodFpx Fpx { get; set; }

        [JsonPropertyName("giropay")]
        public PaymentMethodGiropay Giropay { get; set; }

        [JsonPropertyName("grabpay")]
        public PaymentMethodGrabpay Grabpay { get; set; }

        [JsonPropertyName("ideal")]
        public PaymentMethodIdeal Ideal { get; set; }

        [JsonPropertyName("interac_present")]
        public PaymentMethodInteracPresent InteracPresent { get; set; }

        [JsonPropertyName("klarna")]
        public PaymentMethodKlarna Klarna { get; set; }

        [JsonPropertyName("konbini")]
        public PaymentMethodKonbini Konbini { get; set; }

        [JsonPropertyName("link")]
        public PaymentMethodLink Link { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("oxxo")]
        public PaymentMethodOxxo Oxxo { get; set; }

        [JsonPropertyName("p24")]
        public PaymentMethodP24 P24 { get; set; }

        [JsonPropertyName("paynow")]
        public PaymentMethodPaynow Paynow { get; set; }

        [JsonPropertyName("promptpay")]
        public PaymentMethodPromptpay Promptpay { get; set; }

        /// <summary>
        /// Options to configure Radar. See <a
        /// href="https://stripe.com/docs/radar/radar-session">Radar Session</a> for more
        /// information.
        /// </summary>
        [JsonPropertyName("radar_options")]
        public PaymentMethodRadarOptions RadarOptions { get; set; }

        [JsonPropertyName("sepa_debit")]
        public PaymentMethodSepaDebit SepaDebit { get; set; }

        [JsonPropertyName("sofort")]
        public PaymentMethodSofort Sofort { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>, <c>blik</c>, <c>boleto</c>,
        /// <c>card</c>, <c>card_present</c>, <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>,
        /// <c>giropay</c>, <c>grabpay</c>, <c>ideal</c>, <c>interac_present</c>, <c>klarna</c>,
        /// <c>konbini</c>, <c>link</c>, <c>oxxo</c>, <c>p24</c>, <c>paynow</c>, <c>promptpay</c>,
        /// <c>sepa_debit</c>, <c>sofort</c>, <c>us_bank_account</c>, or <c>wechat_pay</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("us_bank_account")]
        public PaymentMethodUsBankAccount UsBankAccount { get; set; }

        [JsonPropertyName("wechat_pay")]
        public PaymentMethodWechatPay WechatPay { get; set; }
    }
}
