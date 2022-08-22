// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// A <c>Transfer</c> object is created when you move funds between Stripe accounts as part
    /// of Connect.
    ///
    /// Before April 6, 2017, transfers also represented movement of funds from a Stripe account
    /// to a card or bank account. This behavior has since been split out into a <a
    /// href="https://stripe.com/docs/api#payout_object">Payout</a> object, with corresponding
    /// payout endpoints. For more information, read about the <a
    /// href="https://stripe.com/docs/transfer-payout-split">transfer/payout split</a>.
    ///
    /// Related guide: <a href="https://stripe.com/docs/connect/charges-transfers">Creating
    /// Separate Charges and Transfers</a>.
    /// </summary>
    public class Transfer : StripeEntity<Transfer>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Amount in %s to be transferred.
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Amount in %s reversed (can be less than the amount attribute on the transfer if a
        /// partial reversal was issued).
        /// </summary>
        [JsonPropertyName("amount_reversed")]
        public long AmountReversed { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// Balance transaction that describes the impact of this transfer on your account balance.
        /// </summary>
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// Balance transaction that describes the impact of this transfer on your account balance.
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

        /// <summary>
        /// Time that this record of the transfer was first created.
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

        #region Expandable Destination

        /// <summary>
        /// (ID of the Account)
        /// ID of the Stripe account the transfer was sent to.
        /// </summary>
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Stripe account the transfer was sent to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonPropertyName("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        [JsonInclude]
        public ExpandableField<Account> InternalDestination { get; private set; }
        #endregion

        #region Expandable DestinationPayment

        /// <summary>
        /// (ID of the Charge)
        /// If the destination is a Stripe account, this will be the ID of the payment that the
        /// destination account received for the transfer.
        /// </summary>
        [JsonIgnore]
        public string DestinationPaymentId
        {
            get => this.InternalDestinationPayment?.Id;
            set => this.InternalDestinationPayment = SetExpandableFieldId(value, this.InternalDestinationPayment);
        }

        /// <summary>
        /// (Expanded)
        /// If the destination is a Stripe account, this will be the ID of the payment that the
        /// destination account received for the transfer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Charge DestinationPayment
        {
            get => this.InternalDestinationPayment?.ExpandedObject;
            set => this.InternalDestinationPayment = SetExpandableFieldObject(value, this.InternalDestinationPayment);
        }

        [JsonPropertyName("destination_payment")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        [JsonInclude]
        public ExpandableField<Charge> InternalDestinationPayment { get; private set; }
        #endregion

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
        /// A list of reversals that have been applied to the transfer.
        /// </summary>
        [JsonPropertyName("reversals")]
        public StripeList<TransferReversal> Reversals { get; set; }

        /// <summary>
        /// Whether the transfer has been fully reversed. If the transfer is only partially
        /// reversed, this attribute will still be false.
        /// </summary>
        [JsonPropertyName("reversed")]
        public bool Reversed { get; set; }

        #region Expandable SourceTransaction

        /// <summary>
        /// (ID of the Charge)
        /// ID of the charge or payment that was used to fund the transfer. If null, the transfer
        /// was funded from the available balance.
        /// </summary>
        [JsonIgnore]
        public string SourceTransactionId
        {
            get => this.InternalSourceTransaction?.Id;
            set => this.InternalSourceTransaction = SetExpandableFieldId(value, this.InternalSourceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the charge or payment that was used to fund the transfer. If null, the transfer
        /// was funded from the available balance.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Charge SourceTransaction
        {
            get => this.InternalSourceTransaction?.ExpandedObject;
            set => this.InternalSourceTransaction = SetExpandableFieldObject(value, this.InternalSourceTransaction);
        }

        [JsonPropertyName("source_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        [JsonInclude]
        public ExpandableField<Charge> InternalSourceTransaction { get; private set; }
        #endregion

        /// <summary>
        /// The source balance this transfer came from. One of <c>card</c>, <c>fpx</c>, or
        /// <c>bank_account</c>.
        /// </summary>
        [JsonPropertyName("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the <a
        /// href="https://stripe.com/docs/connect/charges-transfers#transfer-options">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
