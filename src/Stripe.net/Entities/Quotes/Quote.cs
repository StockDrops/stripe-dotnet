// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;
    using Stripe.Infrastructure.JsonConverters;

    /// <summary>
    /// A Quote is a way to model prices that you'd like to provide to a customer. Once
    /// accepted, it will automatically create an invoice, subscription or subscription
    /// schedule.
    /// </summary>
    public class Quote : StripeEntity<Quote>, IHasId, IHasMetadata, IHasObject
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
        /// Total before any discounts or taxes are applied.
        /// </summary>
        [JsonPropertyName("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total after discounts and taxes are applied.
        /// </summary>
        [JsonPropertyName("amount_total")]
        public long AmountTotal { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect Application that created the quote.
        /// </summary>
        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connect Application that created the quote.
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

        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. Only applicable if
        /// there are no line items with recurring prices on the quote.
        /// </summary>
        [JsonPropertyName("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the application owner's Stripe account. Only applicable if there are line items with
        /// recurring prices on the quote.
        /// </summary>
        [JsonPropertyName("application_fee_percent")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonPropertyName("automatic_tax")]
        public QuoteAutomaticTax AutomaticTax { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay invoices at the end of the subscription cycle or on
        /// finalization using the default payment method attached to the subscription or customer.
        /// When sending an invoice, Stripe will email your customer an invoice with payment
        /// instructions. Defaults to <c>charge_automatically</c>.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonPropertyName("computed")]
        public QuoteComputed Computed { get; set; }

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
        /// The customer which this quote belongs to. A customer is required before finalizing the
        /// quote. Once specified, it cannot be changed.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The customer which this quote belongs to. A customer is required before finalizing the
        /// quote. Once specified, it cannot be changed.
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

        #region Expandable DefaultTaxRates

        /// <summary>
        /// (IDs of the DefaultTaxRates)
        /// The tax rates applied to this quote.
        /// </summary>
        [JsonIgnore]
        public List<string> DefaultTaxRateIds
        {
            get => this.InternalDefaultTaxRates?.Select((x) => x.Id).ToList();
            set => this.InternalDefaultTaxRates = SetExpandableArrayIds<TaxRate>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The tax rates applied to this quote.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public List<TaxRate> DefaultTaxRates
        {
            get => this.InternalDefaultTaxRates?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDefaultTaxRates = SetExpandableArrayObjects(value);
        }

        [JsonPropertyName("default_tax_rates")]
        internal List<ExpandableField<TaxRate>> InternalDefaultTaxRates { get; set; }
        #endregion

        /// <summary>
        /// A description that will be displayed on the quote PDF.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The discounts applied to this quote.
        /// </summary>
        [JsonIgnore]
        public List<string> DiscountIds
        {
            get => this.InternalDiscounts?.Select((x) => x.Id).ToList();
            set => this.InternalDiscounts = SetExpandableArrayIds<Discount>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The discounts applied to this quote.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonPropertyName("discounts")]
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        /// <summary>
        /// The date on which the quote will be canceled if in <c>open</c> or <c>draft</c> status.
        /// Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A footer that will be displayed on the quote PDF.
        /// </summary>
        [JsonPropertyName("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Details of the quote that was cloned. See the <a
        /// href="https://stripe.com/docs/quotes/clone">cloning documentation</a> for more details.
        /// </summary>
        [JsonPropertyName("from_quote")]
        public QuoteFromQuote FromQuote { get; set; }

        /// <summary>
        /// A header that will be displayed on the quote PDF.
        /// </summary>
        [JsonPropertyName("header")]
        public string Header { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// The invoice that was created from this quote.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// The invoice that was created from this quote.
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

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonPropertyName("invoice_settings")]
        public QuoteInvoiceSettings InvoiceSettings { get; set; }

        /// <summary>
        /// A list of items the customer is being quoted for.
        /// </summary>
        [JsonPropertyName("line_items")]
        public StripeList<LineItem> LineItems { get; set; }

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
        /// A unique number that identifies this particular quote. This number is assigned once the
        /// quote is <a href="https://stripe.com/docs/quotes/overview#finalize">finalized</a>.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account on behalf of which to charge. See the <a
        /// href="https://support.stripe.com/questions/sending-invoices-on-behalf-of-connected-accounts">Connect
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
        /// The account on behalf of which to charge. See the <a
        /// href="https://support.stripe.com/questions/sending-invoices-on-behalf-of-connected-accounts">Connect
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
        /// The status of the quote.
        /// One of: <c>accepted</c>, <c>canceled</c>, <c>draft</c>, or <c>open</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("status_transitions")]
        public QuoteStatusTransitions StatusTransitions { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The subscription that was created or updated from this quote.
        /// </summary>
        [JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        /// <summary>
        /// (Expanded)
        /// The subscription that was created or updated from this quote.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonPropertyName("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        [JsonInclude]
        public ExpandableField<Subscription> InternalSubscription { get; private set; }
        #endregion

        [JsonPropertyName("subscription_data")]
        public QuoteSubscriptionData SubscriptionData { get; set; }

        #region Expandable SubscriptionSchedule

        /// <summary>
        /// (ID of the SubscriptionSchedule)
        /// The subscription schedule that was created or updated from this quote.
        /// </summary>
        [JsonIgnore]
        public string SubscriptionScheduleId
        {
            get => this.InternalSubscriptionSchedule?.Id;
            set => this.InternalSubscriptionSchedule = SetExpandableFieldId(value, this.InternalSubscriptionSchedule);
        }

        /// <summary>
        /// (Expanded)
        /// The subscription schedule that was created or updated from this quote.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public SubscriptionSchedule SubscriptionSchedule
        {
            get => this.InternalSubscriptionSchedule?.ExpandedObject;
            set => this.InternalSubscriptionSchedule = SetExpandableFieldObject(value, this.InternalSubscriptionSchedule);
        }

        [JsonPropertyName("subscription_schedule")]
        [JsonConverter(typeof(ExpandableFieldConverter<SubscriptionSchedule>))]
        [JsonInclude]
        public ExpandableField<SubscriptionSchedule> InternalSubscriptionSchedule { get; private set; }
        #endregion

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock this quote belongs to.
        /// </summary>
        [JsonIgnore]
        public string TestClockId
        {
            get => this.InternalTestClock?.Id;
            set => this.InternalTestClock = SetExpandableFieldId(value, this.InternalTestClock);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the test clock this quote belongs to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public TestHelpers.TestClock TestClock
        {
            get => this.InternalTestClock?.ExpandedObject;
            set => this.InternalTestClock = SetExpandableFieldObject(value, this.InternalTestClock);
        }

        [JsonPropertyName("test_clock")]
        [JsonConverter(typeof(ExpandableFieldConverter<TestHelpers.TestClock>))]
        [JsonInclude]
        public ExpandableField<TestHelpers.TestClock> InternalTestClock { get; private set; }
        #endregion

        [JsonPropertyName("total_details")]
        public QuoteTotalDetails TotalDetails { get; set; }

        /// <summary>
        /// The account (if any) the payments will be attributed to for tax reporting, and where
        /// funds from each payment will be transferred to for each of the invoices.
        /// </summary>
        [JsonPropertyName("transfer_data")]
        public QuoteTransferData TransferData { get; set; }
    }
}
