// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// You can reverse some <a
    /// href="https://stripe.com/docs/api#received_credits">ReceivedCredits</a> depending on
    /// their network and source flow. Reversing a ReceivedCredit leads to the creation of a new
    /// object known as a CreditReversal.
    /// </summary>
    public class CreditReversal : StripeEntity<CreditReversal>, IHasId, IHasMetadata, IHasObject
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
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The FinancialAccount to reverse funds from.
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

        /// <summary>
        /// The rails used to reverse the funds.
        /// One of: <c>ach</c>, or <c>stripe</c>.
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// The ReceivedCredit being reversed.
        /// </summary>
        [JsonPropertyName("received_credit")]
        public string ReceivedCredit { get; set; }

        /// <summary>
        /// Status of the CreditReversal.
        /// One of: <c>canceled</c>, <c>posted</c>, or <c>processing</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("status_transitions")]
        public CreditReversalStatusTransitions StatusTransitions { get; set; }

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
