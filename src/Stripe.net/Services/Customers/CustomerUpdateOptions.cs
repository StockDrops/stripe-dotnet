// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class CustomerUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The customer's address.
        /// </summary>
        [JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// An integer amount in cents (or local equivalent) that represents the customer's current
        /// balance, which affect the customer's future invoices. A negative amount represents a
        /// credit that decreases the amount due on an invoice; a positive amount increases the
        /// amount due on an invoice.
        /// </summary>
        [JsonPropertyName("balance")]
        public long? Balance { get; set; }

        /// <summary>
        /// Balance information and default balance settings for this customer.
        /// </summary>
        [JsonPropertyName("cash_balance")]
        public CustomerCashBalanceOptions CashBalance { get; set; }

        [JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// If you are using payment methods created via the PaymentMethods API, see the <a
        /// href="https://stripe.com/docs/api/customers/update#update_customer-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// parameter.
        ///
        /// Provide the ID of a payment source already attached to this customer to make it this
        /// customer's default payment source.
        ///
        /// If you want to add a new payment source and make it the default, see the <a
        /// href="https://stripe.com/docs/api/customers/update#update_customer-source">source</a>
        /// property.
        /// </summary>
        [JsonPropertyName("default_source")]
        public string DefaultSource { get; set; }

        /// <summary>
        /// An arbitrary string that you can attach to a customer object. It is displayed alongside
        /// the customer in the dashboard.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Customer's email address. It's displayed alongside the customer in your dashboard and
        /// can be useful for searching and tracking. This may be up to <em>512 characters</em>.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The prefix for the customer used to generate unique invoice numbers. Must be 3–12
        /// uppercase letters or numbers.
        /// </summary>
        [JsonPropertyName("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        /// <summary>
        /// Default invoice settings for this customer.
        /// </summary>
        [JsonPropertyName("invoice_settings")]
        public CustomerInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The customer's full name or business name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The sequence to be used on the customer's next invoice. Defaults to 1.
        /// </summary>
        [JsonPropertyName("next_invoice_sequence")]
        public long? NextInvoiceSequence { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Customer's preferred languages, ordered by preference.
        /// </summary>
        [JsonPropertyName("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// The API ID of a promotion code to apply to the customer. The customer will have a
        /// discount applied on all recurring payments. Charges you create through the API will not
        /// have the discount.
        /// </summary>
        [JsonPropertyName("promotion_code")]
        public string PromotionCode { get; set; }

        /// <summary>
        /// The customer's shipping information. Appears on invoices emailed to this customer.
        /// </summary>
        [JsonPropertyName("shipping")]
        public ShippingOptions Shipping { get; set; }

        [JsonPropertyName("source")]
        [JsonConverter(typeof(AnyOfConverterFactory))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        /// <summary>
        /// Tax details about the customer.
        /// </summary>
        [JsonPropertyName("tax")]
        public CustomerTaxOptions Tax { get; set; }

        /// <summary>
        /// The customer's tax exemption. One of <c>none</c>, <c>exempt</c>, or <c>reverse</c>.
        /// </summary>
        [JsonPropertyName("tax_exempt")]
        public string TaxExempt { get; set; }

        [JsonPropertyName("validate")]
        public bool? Validate { get; set; }
    }
}
