// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// Any use of an <a href="https://stripe.com/docs/issuing">issued card</a> that results in
    /// funds entering or leaving your Stripe account, such as a completed purchase or refund,
    /// is represented by an Issuing <c>Transaction</c> object.
    ///
    /// Related guide: <a href="https://stripe.com/docs/issuing/purchases/transactions">Issued
    /// Card Transactions</a>.
    /// </summary>
    public class Transaction : StripeEntity<Transaction>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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

        /// <summary>
        /// The transaction amount, which will be reflected in your balance. This amount is in your
        /// currency and in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest
        /// currency unit</a>.
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Detailed breakdown of amount components. These amounts are denominated in
        /// <c>currency</c> and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonPropertyName("amount_details")]
        public TransactionAmountDetails AmountDetails { get; set; }

        #region Expandable Authorization

        /// <summary>
        /// (ID of the Authorization)
        /// The <c>Authorization</c> object that led to this transaction.
        /// </summary>
        [JsonIgnore]
        public string AuthorizationId
        {
            get => this.InternalAuthorization?.Id;
            set => this.InternalAuthorization = SetExpandableFieldId(value, this.InternalAuthorization);
        }

        /// <summary>
        /// (Expanded)
        /// The <c>Authorization</c> object that led to this transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Authorization Authorization
        {
            get => this.InternalAuthorization?.ExpandedObject;
            set => this.InternalAuthorization = SetExpandableFieldObject(value, this.InternalAuthorization);
        }

        [JsonPropertyName("authorization")]
        [JsonConverter(typeof(ExpandableFieldConverter<Authorization>))]
        [JsonInclude]
        public ExpandableField<Authorization> InternalAuthorization { get; private set; }
        #endregion

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// ID of the <a href="https://stripe.com/docs/api/balance_transactions">balance
        /// transaction</a> associated with this transaction.
        /// </summary>
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the <a href="https://stripe.com/docs/api/balance_transactions">balance
        /// transaction</a> associated with this transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonPropertyName("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        [JsonInclude]
        public ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; private set; }
        #endregion

        #region Expandable Card

        /// <summary>
        /// (ID of the Card)
        /// The card used to make this transaction.
        /// </summary>
        [JsonIgnore]
        public string CardId
        {
            get => this.InternalCard?.Id;
            set => this.InternalCard = SetExpandableFieldId(value, this.InternalCard);
        }

        /// <summary>
        /// (Expanded)
        /// The card used to make this transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Card Card
        {
            get => this.InternalCard?.ExpandedObject;
            set => this.InternalCard = SetExpandableFieldObject(value, this.InternalCard);
        }

        [JsonPropertyName("card")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        [JsonInclude]
        public ExpandableField<Card> InternalCard { get; private set; }
        #endregion

        #region Expandable Cardholder

        /// <summary>
        /// (ID of the Cardholder)
        /// The cardholder to whom this transaction belongs.
        /// </summary>
        [JsonIgnore]
        public string CardholderId
        {
            get => this.InternalCardholder?.Id;
            set => this.InternalCardholder = SetExpandableFieldId(value, this.InternalCardholder);
        }

        /// <summary>
        /// (Expanded)
        /// The cardholder to whom this transaction belongs.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Cardholder Cardholder
        {
            get => this.InternalCardholder?.ExpandedObject;
            set => this.InternalCardholder = SetExpandableFieldObject(value, this.InternalCardholder);
        }

        [JsonPropertyName("cardholder")]
        [JsonConverter(typeof(ExpandableFieldConverter<Cardholder>))]
        [JsonInclude]
        public ExpandableField<Cardholder> InternalCardholder { get; private set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        #region Expandable Dispute

        /// <summary>
        /// (ID of the Dispute)
        /// If you've disputed the transaction, the ID of the dispute.
        /// </summary>
        [JsonIgnore]
        public string DisputeId
        {
            get => this.InternalDispute?.Id;
            set => this.InternalDispute = SetExpandableFieldId(value, this.InternalDispute);
        }

        /// <summary>
        /// (Expanded)
        /// If you've disputed the transaction, the ID of the dispute.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Dispute Dispute
        {
            get => this.InternalDispute?.ExpandedObject;
            set => this.InternalDispute = SetExpandableFieldObject(value, this.InternalDispute);
        }

        [JsonPropertyName("dispute")]
        [JsonConverter(typeof(ExpandableFieldConverter<Dispute>))]
        [JsonInclude]
        public ExpandableField<Dispute> InternalDispute { get; private set; }
        #endregion

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The amount that the merchant will receive, denominated in <c>merchant_currency</c> and
        /// in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest currency
        /// unit</a>. It will be different from <c>amount</c> if the merchant is taking payment in a
        /// different currency.
        /// </summary>
        [JsonPropertyName("merchant_amount")]
        public long MerchantAmount { get; set; }

        /// <summary>
        /// The currency with which the merchant is taking payment.
        /// </summary>
        [JsonPropertyName("merchant_currency")]
        public string MerchantCurrency { get; set; }

        [JsonPropertyName("merchant_data")]
        public AuthorizationMerchantData MerchantData { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Additional purchase information that is optionally provided by the merchant.
        /// </summary>
        [JsonPropertyName("purchase_details")]
        public TransactionPurchaseDetails PurchaseDetails { get; set; }

        /// <summary>
        /// <a href="https://stripe.com/docs/api/treasury">Treasury</a> details related to this
        /// transaction if it was created on a
        /// [FinancialAccount](/docs/api/treasury/financial_accounts.
        /// </summary>
        [JsonPropertyName("treasury")]
        public TransactionTreasury Treasury { get; set; }

        /// <summary>
        /// The nature of the transaction.
        /// One of: <c>capture</c>, or <c>refund</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The digital wallet used for this transaction. One of <c>apple_pay</c>,
        /// <c>google_pay</c>, or <c>samsung_pay</c>.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, or <c>samsung_pay</c>.
        /// </summary>
        [JsonPropertyName("wallet")]
        public string Wallet { get; set; }
    }
}
