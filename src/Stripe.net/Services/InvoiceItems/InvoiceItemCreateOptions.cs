// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class InvoiceItemCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The integer amount in cents (or local equivalent) of the charge to be applied to the
        /// upcoming invoice. Passing in a negative <c>amount</c> will reduce the <c>amount_due</c>
        /// on the invoice.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of the customer who will be billed when this invoice item is billed.
        /// </summary>
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to the invoice item. The description is
        /// displayed in the invoice for easy tracking.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Controls whether discounts apply to this invoice item. Defaults to false for prorations
        /// or negative invoice items, and true for all other invoice items.
        /// </summary>
        [JsonPropertyName("discountable")]
        public bool? Discountable { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the invoice item or invoice line item.
        /// </summary>
        [JsonPropertyName("discounts")]
        public List<InvoiceItemDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The ID of an existing invoice to add this invoice item to. When left blank, the invoice
        /// item will be added to the next upcoming scheduled invoice. This is useful when adding
        /// invoice items in response to an invoice.created webhook. You can only add invoice items
        /// to draft invoices and there is a maximum of 250 items per invoice.
        /// </summary>
        [JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The period associated with this invoice item. When set to different values, the period
        /// will be rendered on the invoice.
        /// </summary>
        [JsonPropertyName("period")]
        public InvoiceItemPeriodOptions Period { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline.
        /// </summary>
        [JsonPropertyName("price_data")]
        public InvoiceItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Non-negative integer. The quantity of units for the invoice item.
        /// </summary>
        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The ID of a subscription to add this invoice item to. When left blank, the invoice item
        /// will be be added to the next upcoming scheduled invoice. When set, scheduled invoices
        /// for subscriptions other than the specified subscription will ignore the invoice item.
        /// Use this when you want to express that an invoice item has been accrued within the
        /// context of a particular subscription.
        /// </summary>
        [JsonPropertyName("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// The tax rates which apply to the invoice item. When set, the <c>default_tax_rates</c> on
        /// the invoice do not apply to this invoice item.
        /// </summary>
        [JsonPropertyName("tax_rates")]
        public List<string> TaxRates { get; set; }

        /// <summary>
        /// The integer unit amount in cents (or local equivalent) of the charge to be applied to
        /// the upcoming invoice. This <c>unit_amount</c> will be multiplied by the quantity to get
        /// the full amount. Passing in a negative <c>unit_amount</c> will reduce the
        /// <c>amount_due</c> on the invoice.
        /// </summary>
        [JsonPropertyName("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but accepts a decimal value in cents (or local equivalent)
        /// with at most 12 decimal places. Only one of <c>unit_amount</c> and
        /// <c>unit_amount_decimal</c> can be set.
        /// </summary>
        [JsonPropertyName("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
