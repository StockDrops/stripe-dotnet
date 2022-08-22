// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// A line item.
    /// </summary>
    public class LineItem : StripeEntity<LineItem>, IHasId, IHasObject
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
        /// Total discount amount applied. If no discounts were applied, defaults to 0.
        /// </summary>
        [JsonPropertyName("amount_discount")]
        public long AmountDiscount { get; set; }

        /// <summary>
        /// Total before any discounts or taxes are applied.
        /// </summary>
        [JsonPropertyName("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total tax amount applied. If no tax was applied, defaults to 0.
        /// </summary>
        [JsonPropertyName("amount_tax")]
        public long AmountTax { get; set; }

        /// <summary>
        /// Total after discounts and taxes.
        /// </summary>
        [JsonPropertyName("amount_total")]
        public long AmountTotal { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonPropertyName("deleted")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// Defaults to product name.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The discounts applied to the line item.
        /// </summary>
        [JsonPropertyName("discounts")]
        public List<LineItemDiscount> Discounts { get; set; }

        /// <summary>
        /// The price used to generate the line item.
        /// </summary>
        [JsonPropertyName("price")]
        public Price Price { get; set; }

        #region Expandable Product

        /// <summary>
        /// (ID of the Product)
        /// The ID of the product for this line item.
        ///
        /// This will always be the same as <c>price.product</c>.
        /// </summary>
        [JsonIgnore]
        public string ProductId
        {
            get => this.InternalProduct?.Id;
            set => this.InternalProduct = SetExpandableFieldId(value, this.InternalProduct);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the product for this line item.
        ///
        /// This will always be the same as <c>price.product</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Product Product
        {
            get => this.InternalProduct?.ExpandedObject;
            set => this.InternalProduct = SetExpandableFieldObject(value, this.InternalProduct);
        }

        [JsonPropertyName("product")]
        [JsonConverter(typeof(ExpandableFieldConverter<Product>))]
        internal ExpandableField<Product> InternalProduct { get; set; }
        #endregion

        /// <summary>
        /// The quantity of products being purchased.
        /// </summary>
        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The taxes applied to the line item.
        /// </summary>
        [JsonPropertyName("taxes")]
        public List<LineItemTax> Taxes { get; set; }
    }
}
