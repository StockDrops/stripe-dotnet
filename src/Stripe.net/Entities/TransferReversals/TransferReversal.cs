// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// <a href="https://stripe.com/docs/connect">Stripe Connect</a> platforms can reverse
    /// transfers made to a connected account, either entirely or partially, and can also
    /// specify whether to refund any related application fees. Transfer reversals add to the
    /// platform's balance and subtract from the destination account's balance.
    ///
    /// Reversing a transfer that was made for a <a
    /// href="https://stripe.com/docs/connect/destination-charges">destination charge</a> is
    /// allowed only up to the amount of the charge. It is possible to reverse a <a
    /// href="https://stripe.com/docs/connect/charges-transfers#transfer-options">transfer_group</a>
    /// transfer only if the destination account has enough balance to cover the reversal.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/connect/charges-transfers#reversing-transfers">Reversing
    /// Transfers</a>.
    /// </summary>
    public class TransferReversal : StripeEntity<TransferReversal>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Amount, in %s.
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// Balance transaction that describes the impact on your account balance.
        /// </summary>
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// Balance transaction that describes the impact on your account balance.
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

        #region Expandable DestinationPaymentRefund

        /// <summary>
        /// (ID of the Refund)
        /// Linked payment refund for the transfer reversal.
        /// </summary>
        [JsonIgnore]
        public string DestinationPaymentRefundId
        {
            get => this.InternalDestinationPaymentRefund?.Id;
            set => this.InternalDestinationPaymentRefund = SetExpandableFieldId(value, this.InternalDestinationPaymentRefund);
        }

        /// <summary>
        /// (Expanded)
        /// Linked payment refund for the transfer reversal.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Refund DestinationPaymentRefund
        {
            get => this.InternalDestinationPaymentRefund?.ExpandedObject;
            set => this.InternalDestinationPaymentRefund = SetExpandableFieldObject(value, this.InternalDestinationPaymentRefund);
        }

        [JsonPropertyName("destination_payment_refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        [JsonInclude]
        public ExpandableField<Refund> InternalDestinationPaymentRefund { get; private set; }
        #endregion

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable SourceRefund

        /// <summary>
        /// (ID of the Refund)
        /// ID of the refund responsible for the transfer reversal.
        /// </summary>
        [JsonIgnore]
        public string SourceRefundId
        {
            get => this.InternalSourceRefund?.Id;
            set => this.InternalSourceRefund = SetExpandableFieldId(value, this.InternalSourceRefund);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the refund responsible for the transfer reversal.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Refund SourceRefund
        {
            get => this.InternalSourceRefund?.ExpandedObject;
            set => this.InternalSourceRefund = SetExpandableFieldObject(value, this.InternalSourceRefund);
        }

        [JsonPropertyName("source_refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        [JsonInclude]
        public ExpandableField<Refund> InternalSourceRefund { get; private set; }
        #endregion

        #region Expandable Transfer

        /// <summary>
        /// (ID of the Transfer)
        /// ID of the transfer that was reversed.
        /// </summary>
        [JsonIgnore]
        public string TransferId
        {
            get => this.InternalTransfer?.Id;
            set => this.InternalTransfer = SetExpandableFieldId(value, this.InternalTransfer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the transfer that was reversed.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Transfer Transfer
        {
            get => this.InternalTransfer?.ExpandedObject;
            set => this.InternalTransfer = SetExpandableFieldObject(value, this.InternalTransfer);
        }

        [JsonPropertyName("transfer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transfer>))]
        [JsonInclude]
        public ExpandableField<Transfer> InternalTransfer { get; private set; }
        #endregion
    }
}
