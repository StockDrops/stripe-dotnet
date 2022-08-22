// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// This object represents a customer of your business. It lets you create recurring charges
    /// and track payments that belong to the same customer.
    ///
    /// Related guide: <a href="https://stripe.com/docs/payments/save-during-payment">Save a
    /// card during payment</a>.
    /// </summary>
    public class Customer : StripeEntity<Customer>, IHasId, IHasMetadata, IHasObject
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
        /// The customer's address.
        /// </summary>
        [JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Current balance, if any, being stored on the customer. If negative, the customer has
        /// credit to apply to their next invoice. If positive, the customer has an amount owed that
        /// will be added to their next invoice. The balance does not refer to any unpaid invoices;
        /// it solely takes into account amounts that have yet to be successfully applied to any
        /// invoice. This balance is only taken into account as invoices are finalized.
        /// </summary>
        [JsonPropertyName("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// The current funds being held by Stripe on behalf of the customer. These funds can be
        /// applied towards payment intents with source "cash_balance".The
        /// settings[reconciliation_mode] field describes whether these funds are applied to such
        /// payment intents manually or automatically.
        /// </summary>
        [JsonPropertyName("cash_balance")]
        public CashBalance CashBalance { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code for the currency</a>
        /// the customer can be charged in for recurring billing purposes.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        #region Expandable DefaultSource

        /// <summary>
        /// (ID of the IPaymentSource)
        /// ID of the default payment source for the customer.
        ///
        /// If you are using payment methods created via the PaymentMethods API, see the <a
        /// href="https://stripe.com/docs/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// field instead.
        /// </summary>
        [JsonIgnore]
        public string DefaultSourceId
        {
            get => this.InternalDefaultSource?.Id;
            set => this.InternalDefaultSource = SetExpandableFieldId(value, this.InternalDefaultSource);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the default payment source for the customer.
        ///
        /// If you are using payment methods created via the PaymentMethods API, see the <a
        /// href="https://stripe.com/docs/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// field instead.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public IPaymentSource DefaultSource
        {
            get => this.InternalDefaultSource?.ExpandedObject;
            set => this.InternalDefaultSource = SetExpandableFieldObject(value, this.InternalDefaultSource);
        }

        [JsonPropertyName("default_source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
        internal ExpandableField<IPaymentSource> InternalDefaultSource { get; set; }
        #endregion

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonPropertyName("deleted")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// When the customer's latest invoice is billed by charging automatically,
        /// <c>delinquent</c> is <c>true</c> if the invoice's latest charge failed. When the
        /// customer's latest invoice is billed by sending an invoice, <c>delinquent</c> is
        /// <c>true</c> if the invoice isn't paid by its due date.
        ///
        /// If an invoice is marked uncollectible by <a
        /// href="https://stripe.com/docs/billing/automatic-collection">dunning</a>,
        /// <c>delinquent</c> doesn't get reset to <c>false</c>.
        /// </summary>
        [JsonPropertyName("delinquent")]
        public bool? Delinquent { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Describes the current discount active on the customer, if there is one.
        /// </summary>
        [JsonPropertyName("discount")]
        public Discount Discount { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The current multi-currency balances, if any, being stored on the customer.If positive in
        /// a currency, the customer has a credit to apply to their next invoice denominated in that
        /// currency.If negative, the customer has an amount owed that will be added to their next
        /// invoice denominated in that currency. These balances do not refer to any unpaid
        /// invoices.They solely track amounts that have yet to be successfully applied to any
        /// invoice. A balance in a particular currency is only applied to any invoice as an invoice
        /// in that currency is finalized.
        /// </summary>
        [JsonPropertyName("invoice_credit_balance")]
        public Dictionary<string, long> InvoiceCreditBalance { get; set; }

        /// <summary>
        /// The prefix for the customer used to generate unique invoice numbers.
        /// </summary>
        [JsonPropertyName("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonPropertyName("invoice_settings")]
        public CustomerInvoiceSettings InvoiceSettings { get; set; }

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
        /// The customer's full name or business name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The suffix of the customer's next invoice number, e.g., 0001.
        /// </summary>
        [JsonPropertyName("next_invoice_sequence")]
        public long NextInvoiceSequence { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The customer's preferred locales (languages), ordered by preference.
        /// </summary>
        [JsonPropertyName("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// Mailing and shipping address for the customer. Appears on invoices emailed to this
        /// customer.
        /// </summary>
        [JsonPropertyName("shipping")]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// The customer's payment sources, if any.
        /// </summary>
        [JsonPropertyName("sources")]
        public StripeList<IPaymentSource> Sources { get; set; }

        /// <summary>
        /// The customer's current subscriptions, if any.
        /// </summary>
        [JsonPropertyName("subscriptions")]
        public StripeList<Subscription> Subscriptions { get; set; }

        [JsonPropertyName("tax")]
        public CustomerTax Tax { get; set; }

        /// <summary>
        /// Describes the customer's tax exemption status. One of <c>none</c>, <c>exempt</c>, or
        /// <c>reverse</c>. When set to <c>reverse</c>, invoice and receipt PDFs include the text
        /// <strong>"Reverse charge"</strong>.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonPropertyName("tax_exempt")]
        public string TaxExempt { get; set; }

        /// <summary>
        /// The customer's tax IDs.
        /// </summary>
        [JsonPropertyName("tax_ids")]
        public StripeList<TaxId> TaxIds { get; set; }

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock this customer belongs to.
        /// </summary>
        [JsonIgnore]
        public string TestClockId
        {
            get => this.InternalTestClock?.Id;
            set => this.InternalTestClock = SetExpandableFieldId(value, this.InternalTestClock);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the test clock this customer belongs to.
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
        internal ExpandableField<TestHelpers.TestClock> InternalTestClock { get; set; }
        #endregion
    }
}
