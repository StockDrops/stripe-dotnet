// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// ReceivedDebits represent funds pulled from a <a
    /// href="https://stripe.com/docs/api#financial_accounts">FinancialAccount</a>. These are
    /// not initiated from the FinancialAccount.
    /// </summary>
    public class ReceivedDebit : StripeEntity<ReceivedDebit>, IHasId, IHasObject
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
        /// Amount (in cents) transferred.
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

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

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Reason for the failure. A ReceivedDebit might fail because the FinancialAccount doesn't
        /// have sufficient funds, is closed, or is frozen.
        /// One of: <c>account_closed</c>, <c>account_frozen</c>, <c>insufficient_funds</c>, or
        /// <c>other</c>.
        /// </summary>
        [JsonPropertyName("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// The FinancialAccount that funds were pulled from.
        /// </summary>
        [JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// A <a href="https://stripe.com/docs/treasury/moving-money/regulatory-receipts">hosted
        /// transaction receipt</a> URL that is provided when money movement is considered regulated
        /// under Stripe's money transmission licenses.
        /// </summary>
        [JsonPropertyName("hosted_regulatory_receipt_url")]
        public string HostedRegulatoryReceiptUrl { get; set; }

        [JsonPropertyName("initiating_payment_method_details")]
        public ReceivedDebitInitiatingPaymentMethodDetails InitiatingPaymentMethodDetails { get; set; }

        [JsonPropertyName("linked_flows")]
        public ReceivedDebitLinkedFlows LinkedFlows { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The network used for the ReceivedDebit.
        /// One of: <c>ach</c>, <c>card</c>, or <c>stripe</c>.
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// Details describing when a ReceivedDebit might be reversed.
        /// </summary>
        [JsonPropertyName("reversal_details")]
        public ReceivedDebitReversalDetails ReversalDetails { get; set; }

        /// <summary>
        /// Status of the ReceivedDebit. ReceivedDebits are created with a status of either
        /// <c>succeeded</c> (approved) or <c>failed</c> (declined). The failure reason can be found
        /// under the <c>failure_code</c>.
        /// One of: <c>failed</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        #region Expandable Transaction

        /// <summary>
        /// (ID of the Transaction)
        /// The Transaction associated with this object.
        /// </summary>
        [JsonIgnore]
        public string TransactionId
        {
            get => this.InternalTransaction?.Id;
            set => this.InternalTransaction = SetExpandableFieldId(value, this.InternalTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// The Transaction associated with this object.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Transaction Transaction
        {
            get => this.InternalTransaction?.ExpandedObject;
            set => this.InternalTransaction = SetExpandableFieldObject(value, this.InternalTransaction);
        }

        [JsonPropertyName("transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transaction>))]
        [JsonInclude]
        public ExpandableField<Transaction> InternalTransaction { get; private set; }
        #endregion
    }
}
