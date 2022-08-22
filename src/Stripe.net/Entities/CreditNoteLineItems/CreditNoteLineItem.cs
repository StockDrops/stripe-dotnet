// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure.JsonConverters;

    public class CreditNoteLineItem : StripeEntity<CreditNoteLineItem>, IHasId, IHasObject
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
        /// The integer amount in %s representing the gross amount being credited for this line
        /// item, excluding (exclusive) tax and discounts.
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The integer amount in %s representing the amount being credited for this line item,
        /// excluding all tax and discounts.
        /// </summary>
        [JsonPropertyName("amount_excluding_tax")]
        public long? AmountExcludingTax { get; set; }

        /// <summary>
        /// Description of the item being credited.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The integer amount in %s representing the discount being credited for this line item.
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// The amount of discount calculated per discount for this line item.
        /// </summary>
        [JsonPropertyName("discount_amounts")]
        public List<CreditNoteLineItemDiscountAmount> DiscountAmounts { get; set; }

        /// <summary>
        /// ID of the invoice line item being credited.
        /// </summary>
        [JsonPropertyName("invoice_line_item")]
        public string InvoiceLineItem { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The number of units of product being credited.
        /// </summary>
        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The amount of tax calculated per tax rate for this line item.
        /// </summary>
        [JsonPropertyName("tax_amounts")]
        public List<CreditNoteTaxAmount> TaxAmounts { get; set; }

        /// <summary>
        /// The tax rates which apply to the line item.
        /// </summary>
        [JsonPropertyName("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }

        /// <summary>
        /// The type of the credit note line item, one of <c>invoice_line_item</c> or
        /// <c>custom_line_item</c>. When the type is <c>invoice_line_item</c> there is an
        /// additional <c>invoice_line_item</c> property on the resource the value of which is the
        /// id of the credited line item on the invoice.
        /// One of: <c>custom_line_item</c>, or <c>invoice_line_item</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The cost of each unit of product being credited.
        /// </summary>
        [JsonPropertyName("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but contains a decimal value with at most 12 decimal places.
        /// </summary>
        [JsonPropertyName("unit_amount_decimal")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? UnitAmountDecimal { get; set; }

        /// <summary>
        /// The amount in %s representing the unit amount being credited for this line item,
        /// excluding all tax and discounts.
        /// </summary>
        [JsonPropertyName("unit_amount_excluding_tax")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? UnitAmountExcludingTax { get; set; }
    }
}
