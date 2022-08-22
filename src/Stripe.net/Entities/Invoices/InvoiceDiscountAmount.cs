namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class InvoiceDiscountAmount : StripeEntity<InvoiceDiscountAmount>
    {
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        #region Expandable Discount

        [JsonIgnore]
        public string DiscountId
        {
            get => this.InternalDiscount?.Id;
            set => this.InternalDiscount = SetExpandableFieldId(value, this.InternalDiscount);
        }

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
