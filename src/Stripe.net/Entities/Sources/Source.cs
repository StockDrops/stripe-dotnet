// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// <c>Source</c> objects allow you to accept a variety of payment methods. They represent a
    /// customer's payment instrument, and can be used with the Stripe API just like a
    /// <c>Card</c> object: once chargeable, they can be charged, or can be attached to
    /// customers.
    ///
    /// Related guides: <a href="https://stripe.com/docs/sources">Sources API</a> and <a
    /// href="https://stripe.com/docs/sources/customers">Sources &amp; Customers</a>.
    /// </summary>
    public class Source : StripeEntity<Source>, IHasId, IHasMetadata, IHasObject, IPaymentSource
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

        [JsonPropertyName("ach_credit_transfer")]
        public SourceAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonPropertyName("ach_debit")]
        public SourceAchDebit AchDebit { get; set; }

        [JsonPropertyName("acss_debit")]
        public SourceAcssDebit AcssDebit { get; set; }

        [JsonPropertyName("alipay")]
        public SourceAlipay Alipay { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for
        /// ¥1, Japanese Yen being a zero-decimal currency) representing the total amount associated
        /// with the source. This is the amount for which the source will be chargeable once ready.
        /// Required for <c>single_use</c> sources.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("au_becs_debit")]
        public SourceAuBecsDebit AuBecsDebit { get; set; }

        [JsonPropertyName("bancontact")]
        public SourceBancontact Bancontact { get; set; }

        [JsonPropertyName("card")]
        public SourceCard Card { get; set; }

        [JsonPropertyName("card_present")]
        public SourceCardPresent CardPresent { get; set; }

        /// <summary>
        /// The client secret of the source. Used for client-side retrieval using a publishable key.
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        [JsonPropertyName("code_verification")]
        public SourceCodeVerification CodeVerification { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code for the currency</a>
        /// associated with the source. This is the currency for which the source will be chargeable
        /// once ready. Required for <c>single_use</c> sources.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of the customer to which this source is attached. This will not be present when
        /// the source has not been attached to a customer.
        /// </summary>
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("eps")]
        public SourceEps Eps { get; set; }

        /// <summary>
        /// The authentication <c>flow</c> of the source. <c>flow</c> is one of <c>redirect</c>,
        /// <c>receiver</c>, <c>code_verification</c>, <c>none</c>.
        /// </summary>
        [JsonPropertyName("flow")]
        public string Flow { get; set; }

        [JsonPropertyName("giropay")]
        public SourceGiropay Giropay { get; set; }

        [JsonPropertyName("ideal")]
        public SourceIdeal Ideal { get; set; }

        [JsonPropertyName("klarna")]
        public SourceKlarna Klarna { get; set; }

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

        [JsonPropertyName("multibanco")]
        public SourceMultibanco Multibanco { get; set; }

        /// <summary>
        /// Information about the owner of the payment instrument that may be used or required by
        /// particular source types.
        /// </summary>
        [JsonPropertyName("owner")]
        public SourceOwner Owner { get; set; }

        [JsonPropertyName("p24")]
        public SourceP24 P24 { get; set; }

        [JsonPropertyName("receiver")]
        public SourceReceiver Receiver { get; set; }

        [JsonPropertyName("redirect")]
        public SourceRedirect Redirect { get; set; }

        [JsonPropertyName("sepa_credit_transfer")]
        public SourceSepaCreditTransfer SepaCreditTransfer { get; set; }

        [JsonPropertyName("sepa_debit")]
        public SourceSepaDebit SepaDebit { get; set; }

        [JsonPropertyName("sofort")]
        public SourceSofort Sofort { get; set; }

        [JsonPropertyName("source_order")]
        public SourceSourceOrder SourceOrder { get; set; }

        /// <summary>
        /// Extra information about a source. This will appear on your customer's statement every
        /// time you charge the source.
        /// </summary>
        [JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The status of the source, one of <c>canceled</c>, <c>chargeable</c>, <c>consumed</c>,
        /// <c>failed</c>, or <c>pending</c>. Only <c>chargeable</c> sources can be used to create a
        /// charge.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("three_d_secure")]
        public SourceThreeDSecure ThreeDSecure { get; set; }

        /// <summary>
        /// The <c>type</c> of the source. The <c>type</c> is a payment method, one of
        /// <c>ach_credit_transfer</c>, <c>ach_debit</c>, <c>alipay</c>, <c>bancontact</c>,
        /// <c>card</c>, <c>card_present</c>, <c>eps</c>, <c>giropay</c>, <c>ideal</c>,
        /// <c>multibanco</c>, <c>klarna</c>, <c>p24</c>, <c>sepa_debit</c>, <c>sofort</c>,
        /// <c>three_d_secure</c>, or <c>wechat</c>. An additional hash is included on the source
        /// with a name matching this value. It contains additional information specific to the <a
        /// href="https://stripe.com/docs/sources">payment method</a> used.
        /// One of: <c>ach_credit_transfer</c>, <c>ach_debit</c>, <c>acss_debit</c>, <c>alipay</c>,
        /// <c>au_becs_debit</c>, <c>bancontact</c>, <c>card</c>, <c>card_present</c>, <c>eps</c>,
        /// <c>giropay</c>, <c>ideal</c>, <c>klarna</c>, <c>multibanco</c>, <c>p24</c>,
        /// <c>sepa_credit_transfer</c>, <c>sepa_debit</c>, <c>sofort</c>, <c>three_d_secure</c>, or
        /// <c>wechat</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Either <c>reusable</c> or <c>single_use</c>. Whether this source should be reusable or
        /// not. Some source types may or may not be reusable by construction, while others may
        /// leave the option at creation. If an incompatible value is passed, an error will be
        /// returned.
        /// </summary>
        [JsonPropertyName("usage")]
        public string Usage { get; set; }

        [JsonPropertyName("wechat")]
        public SourceWechat Wechat { get; set; }
    }
}
