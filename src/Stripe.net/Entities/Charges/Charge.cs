// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// To charge a credit or a debit card, you create a <c>Charge</c> object. You can retrieve
    /// and refund individual charges as well as list all charges. Charges are identified by a
    /// unique, random ID.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/payments/accept-a-payment-charges">Accept a payment with
    /// the Charges API</a>.
    /// </summary>
    public class Charge : StripeEntity<Charge>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Amount intended to be collected by this payment. A positive integer representing how
        /// much to charge in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest
        /// currency unit</a> (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal
        /// currency). The minimum amount is $0.50 US or <a
        /// href="https://stripe.com/docs/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>. The amount value supports up to eight digits (e.g., a value of
        /// 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Amount in %s captured (can be less than the amount attribute on the charge if a partial
        /// capture was made).
        /// </summary>
        [JsonPropertyName("amount_captured")]
        public long AmountCaptured { get; set; }

        /// <summary>
        /// Amount in %s refunded (can be less than the amount attribute on the charge if a partial
        /// refund was issued).
        /// </summary>
        [JsonPropertyName("amount_refunded")]
        public long AmountRefunded { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect application that created the charge.
        /// </summary>
        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connect application that created the charge.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonPropertyName("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        [JsonInclude]
        public ExpandableField<Application> InternalApplication { get; private set; }
        #endregion

        #region Expandable ApplicationFee

        /// <summary>
        /// (ID of the ApplicationFee)
        /// The application fee (if any) for the charge. <a
        /// href="https://stripe.com/docs/connect/direct-charges#collecting-fees">See the Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonIgnore]
        public string ApplicationFeeId
        {
            get => this.InternalApplicationFee?.Id;
            set => this.InternalApplicationFee = SetExpandableFieldId(value, this.InternalApplicationFee);
        }

        /// <summary>
        /// (Expanded)
        /// The application fee (if any) for the charge. <a
        /// href="https://stripe.com/docs/connect/direct-charges#collecting-fees">See the Connect
        /// documentation</a> for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public ApplicationFee ApplicationFee
        {
            get => this.InternalApplicationFee?.ExpandedObject;
            set => this.InternalApplicationFee = SetExpandableFieldObject(value, this.InternalApplicationFee);
        }

        [JsonPropertyName("application_fee")]
        [JsonConverter(typeof(ExpandableFieldConverter<ApplicationFee>))]
        [JsonInclude]
        public ExpandableField<ApplicationFee> InternalApplicationFee { get; private set; }
        #endregion

        /// <summary>
        /// The amount of the application fee (if any) requested for the charge. <a
        /// href="https://stripe.com/docs/connect/direct-charges#collecting-fees">See the Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonPropertyName("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Authorization code on the charge.
        /// </summary>
        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// ID of the balance transaction that describes the impact of this charge on your account
        /// balance (not including refunds or disputes).
        /// </summary>
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the balance transaction that describes the impact of this charge on your account
        /// balance (not including refunds or disputes).
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

        [JsonPropertyName("billing_details")]
        public ChargeBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The full statement descriptor that is passed to card networks, and that is displayed on
        /// your customers' credit card and bank statements. Allows you to see what the statement
        /// descriptor looks like after the static and dynamic portions are combined.
        /// </summary>
        [JsonPropertyName("calculated_statement_descriptor")]
        public string CalculatedStatementDescriptor { get; set; }

        /// <summary>
        /// If the charge was created without capturing, this Boolean represents whether it is still
        /// uncaptured or has since been captured.
        /// </summary>
        [JsonPropertyName("captured")]
        public bool Captured { get; set; }

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

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the customer this charge is for if one exists.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the customer this charge is for if one exists.
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
        [JsonInclude]
        public ExpandableField<Customer> InternalCustomer { get; private set; }
        #endregion

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        #region Expandable Destination

        /// <summary>
        /// (ID of the Account)
        /// ID of an existing, connected Stripe account to transfer funds to if <c>transfer_data</c>
        /// was specified in the charge request.
        /// </summary>
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// ID of an existing, connected Stripe account to transfer funds to if <c>transfer_data</c>
        /// was specified in the charge request.
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

        #region Expandable Dispute

        /// <summary>
        /// (ID of the Dispute)
        /// Details about the dispute if the charge has been disputed.
        /// </summary>
        [JsonIgnore]
        public string DisputeId
        {
            get => this.InternalDispute?.Id;
            set => this.InternalDispute = SetExpandableFieldId(value, this.InternalDispute);
        }

        /// <summary>
        /// (Expanded)
        /// Details about the dispute if the charge has been disputed.
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
        /// Whether the charge has been disputed.
        /// </summary>
        [JsonPropertyName("disputed")]
        public bool Disputed { get; set; }

        #region Expandable FailureBalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// ID of the balance transaction that describes the reversal of the balance on your account
        /// due to payment failure.
        /// </summary>
        [JsonIgnore]
        public string FailureBalanceTransactionId
        {
            get => this.InternalFailureBalanceTransaction?.Id;
            set => this.InternalFailureBalanceTransaction = SetExpandableFieldId(value, this.InternalFailureBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the balance transaction that describes the reversal of the balance on your account
        /// due to payment failure.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public BalanceTransaction FailureBalanceTransaction
        {
            get => this.InternalFailureBalanceTransaction?.ExpandedObject;
            set => this.InternalFailureBalanceTransaction = SetExpandableFieldObject(value, this.InternalFailureBalanceTransaction);
        }

        [JsonPropertyName("failure_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        [JsonInclude]
        public ExpandableField<BalanceTransaction> InternalFailureBalanceTransaction { get; private set; }
        #endregion

        /// <summary>
        /// Error code explaining reason for charge failure if available (see <a
        /// href="https://stripe.com/docs/api#errors">the errors section</a> for a list of codes).
        /// </summary>
        [JsonPropertyName("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// Message to user further explaining reason for charge failure if available.
        /// </summary>
        [JsonPropertyName("failure_message")]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Information on fraud assessments for the charge.
        /// </summary>
        [JsonPropertyName("fraud_details")]
        public ChargeFraudDetails FraudDetails { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// ID of the invoice this charge is for if one exists.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the invoice this charge is for if one exists.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonPropertyName("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        [JsonInclude]
        public ExpandableField<Invoice> InternalInvoice { get; private set; }
        #endregion

        [JsonPropertyName("level3")]
        public ChargeLevel3 Level3 { get; set; }

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

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account (if any) the charge was made on behalf of without triggering an automatic
        /// transfer. See the <a href="https://stripe.com/docs/connect/charges-transfers">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        /// <summary>
        /// (Expanded)
        /// The account (if any) the charge was made on behalf of without triggering an automatic
        /// transfer. See the <a href="https://stripe.com/docs/connect/charges-transfers">Connect
        /// documentation</a> for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonPropertyName("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        [JsonInclude]
        public ExpandableField<Account> InternalOnBehalfOf { get; private set; }
        #endregion

        /// <summary>
        /// Details about whether the payment was accepted, and why. See <a
        /// href="https://stripe.com/docs/declines">understanding declines</a> for details.
        /// </summary>
        [JsonPropertyName("outcome")]
        public ChargeOutcome Outcome { get; set; }

        /// <summary>
        /// <c>true</c> if the charge succeeded, or was successfully authorized for later capture.
        /// </summary>
        [JsonPropertyName("paid")]
        public bool Paid { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// ID of the PaymentIntent associated with this charge, if one exists.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the PaymentIntent associated with this charge, if one exists.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonPropertyName("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        [JsonInclude]
        public ExpandableField<PaymentIntent> InternalPaymentIntent { get; private set; }
        #endregion

        /// <summary>
        /// ID of the payment method used in this charge.
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Details about the payment method at the time of the transaction.
        /// </summary>
        [JsonPropertyName("payment_method_details")]
        public ChargePaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// Options to configure Radar. See <a
        /// href="https://stripe.com/docs/radar/radar-session">Radar Session</a> for more
        /// information.
        /// </summary>
        [JsonPropertyName("radar_options")]
        public ChargeRadarOptions RadarOptions { get; set; }

        /// <summary>
        /// This is the email address that the receipt for this charge was sent to.
        /// </summary>
        [JsonPropertyName("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// This is the transaction number that appears on email receipts sent for this charge. This
        /// attribute will be <c>null</c> until a receipt has been sent.
        /// </summary>
        [JsonPropertyName("receipt_number")]
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// This is the URL to view the receipt for this charge. The receipt is kept up-to-date to
        /// the latest state of the charge, including any refunds. If the charge is for an Invoice,
        /// the receipt will be stylized as an Invoice receipt.
        /// </summary>
        [JsonPropertyName("receipt_url")]
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// Whether the charge has been fully refunded. If the charge is only partially refunded,
        /// this attribute will still be false.
        /// </summary>
        [JsonPropertyName("refunded")]
        public bool Refunded { get; set; }

        /// <summary>
        /// A list of refunds that have been applied to the charge.
        /// </summary>
        [JsonPropertyName("refunds")]
        public StripeList<Refund> Refunds { get; set; }

        #region Expandable Review

        /// <summary>
        /// (ID of the Review)
        /// ID of the review associated with this charge if one exists.
        /// </summary>
        [JsonIgnore]
        public string ReviewId
        {
            get => this.InternalReview?.Id;
            set => this.InternalReview = SetExpandableFieldId(value, this.InternalReview);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the review associated with this charge if one exists.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Review Review
        {
            get => this.InternalReview?.ExpandedObject;
            set => this.InternalReview = SetExpandableFieldObject(value, this.InternalReview);
        }

        [JsonPropertyName("review")]
        [JsonConverter(typeof(ExpandableFieldConverter<Review>))]
        [JsonInclude]
        public ExpandableField<Review> InternalReview { get; private set; }
        #endregion

        /// <summary>
        /// Shipping information for the charge.
        /// </summary>
        [JsonPropertyName("shipping")]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// This is a legacy field that will be removed in the future. It contains the Source, Card,
        /// or BankAccount object used for the charge. For details about the payment method used for
        /// this charge, refer to <c>payment_method</c> or <c>payment_method_details</c> instead.
        /// </summary>
        [JsonPropertyName("source")]
        [JsonConverter(typeof(StripeObjectConverter<IPaymentSource>))]
        public IPaymentSource Source { get; set; }

        #region Expandable SourceTransfer

        /// <summary>
        /// (ID of the Transfer)
        /// The transfer ID which created this charge. Only present if the charge came from another
        /// Stripe account. <a href="https://stripe.com/docs/connect/destination-charges">See the
        /// Connect documentation</a> for details.
        /// </summary>
        [JsonIgnore]
        public string SourceTransferId
        {
            get => this.InternalSourceTransfer?.Id;
            set => this.InternalSourceTransfer = SetExpandableFieldId(value, this.InternalSourceTransfer);
        }

        /// <summary>
        /// (Expanded)
        /// The transfer ID which created this charge. Only present if the charge came from another
        /// Stripe account. <a href="https://stripe.com/docs/connect/destination-charges">See the
        /// Connect documentation</a> for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Transfer SourceTransfer
        {
            get => this.InternalSourceTransfer?.ExpandedObject;
            set => this.InternalSourceTransfer = SetExpandableFieldObject(value, this.InternalSourceTransfer);
        }

        [JsonPropertyName("source_transfer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transfer>))]
        [JsonInclude]
        public ExpandableField<Transfer> InternalSourceTransfer { get; private set; }
        #endregion

        /// <summary>
        /// For card charges, use <c>statement_descriptor_suffix</c> instead. Otherwise, you can use
        /// this value as the complete description of a charge on your customers’ statements. Must
        /// contain at least one letter, maximum 22 characters.
        /// </summary>
        [JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about the charge that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that’s set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonPropertyName("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// The status of the payment is either <c>succeeded</c>, <c>pending</c>, or <c>failed</c>.
        /// One of: <c>failed</c>, <c>pending</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        #region Expandable Transfer

        /// <summary>
        /// (ID of the Transfer)
        /// ID of the transfer to the <c>destination</c> account (only applicable if the charge was
        /// created using the <c>destination</c> parameter).
        /// </summary>
        [JsonIgnore]
        public string TransferId
        {
            get => this.InternalTransfer?.Id;
            set => this.InternalTransfer = SetExpandableFieldId(value, this.InternalTransfer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the transfer to the <c>destination</c> account (only applicable if the charge was
        /// created using the <c>destination</c> parameter).
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

        /// <summary>
        /// An optional dictionary including the account to automatically transfer to as part of a
        /// destination charge. <a href="https://stripe.com/docs/connect/destination-charges">See
        /// the Connect documentation</a> for details.
        /// </summary>
        [JsonPropertyName("transfer_data")]
        public ChargeTransferData TransferData { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the <a
        /// href="https://stripe.com/docs/connect/charges-transfers#transfer-options">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
