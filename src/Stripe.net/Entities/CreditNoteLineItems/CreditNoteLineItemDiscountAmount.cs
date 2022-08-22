// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class CreditNoteLineItemDiscountAmount : StripeEntity<CreditNoteLineItemDiscountAmount>
    {
        /// <summary>
        /// The amount, in %s, of the discount.
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        #region Expandable Discount

        /// <summary>
        /// (ID of the Discount)
        /// The discount that was applied to get this discount amount.
        /// </summary>
        [JsonIgnore]
        public string DiscountId
        {
            get => this.InternalDiscount?.Id;
            set => this.InternalDiscount = SetExpandableFieldId(value, this.InternalDiscount);
        }

        /// <summary>
        /// (Expanded)
        /// The discount that was applied to get this discount amount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Discount Discount
        {
            get => this.InternalDiscount?.ExpandedObject;
            set => this.InternalDiscount = SetExpandableFieldObject(value, this.InternalDiscount);
        }

        [JsonPropertyName("discount")]
        [JsonConverter(typeof(ExpandableFieldConverter<Discount>))]
        [JsonInclude]
        public ExpandableField<Discount> InternalDiscount { get; private set; }
        #endregion
    }
}
