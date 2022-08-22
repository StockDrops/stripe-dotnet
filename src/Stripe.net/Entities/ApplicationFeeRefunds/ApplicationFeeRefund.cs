// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// <c>Application Fee Refund</c> objects allow you to refund an application fee that has
    /// previously been created but not yet refunded. Funds will be refunded to the Stripe
    /// account from which the fee was originally collected.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/connect/destination-charges#refunding-app-fee">Refunding
    /// Application Fees</a>.
    /// </summary>
    public class ApplicationFeeRefund : StripeEntity<ApplicationFeeRefund>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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

        #region Expandable Fee

        /// <summary>
        /// (ID of the ApplicationFee)
        /// ID of the application fee that was refunded.
        /// </summary>
        [JsonIgnore]
        public string FeeId
        {
            get => this.InternalFee?.Id;
            set => this.InternalFee = SetExpandableFieldId(value, this.InternalFee);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the application fee that was refunded.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public ApplicationFee Fee
        {
            get => this.InternalFee?.ExpandedObject;
            set => this.InternalFee = SetExpandableFieldObject(value, this.InternalFee);
        }

        [JsonPropertyName("fee")]
        [JsonConverter(typeof(ExpandableFieldConverter<ApplicationFee>))]
        [JsonInclude]
        public ExpandableField<ApplicationFee> InternalFee { get; private set; }
        #endregion

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
