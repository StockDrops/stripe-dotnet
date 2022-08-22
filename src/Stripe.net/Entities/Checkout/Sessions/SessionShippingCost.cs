// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SessionShippingCost : StripeEntity<SessionShippingCost>
    {
        /// <summary>
        /// Total shipping cost before any discounts or taxes are applied.
        /// </summary>
        [JsonPropertyName("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total tax amount applied due to shipping costs. If no tax was applied, defaults to 0.
        /// </summary>
        [JsonPropertyName("amount_tax")]
        public long AmountTax { get; set; }

        /// <summary>
        /// Total shipping cost after discounts and taxes are applied.
        /// </summary>
        [JsonPropertyName("amount_total")]
        public long AmountTotal { get; set; }

        #region Expandable ShippingRate

        /// <summary>
        /// (ID of the ShippingRate)
        /// The ID of the ShippingRate for this order.
        /// </summary>
        [JsonIgnore]
        public string ShippingRateId
        {
            get => this.InternalShippingRate?.Id;
            set => this.InternalShippingRate = SetExpandableFieldId(value, this.InternalShippingRate);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the ShippingRate for this order.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public ShippingRate ShippingRate
        {
            get => this.InternalShippingRate?.ExpandedObject;
            set => this.InternalShippingRate = SetExpandableFieldObject(value, this.InternalShippingRate);
        }

        [JsonPropertyName("shipping_rate")]
        [JsonConverter(typeof(ExpandableFieldConverter<ShippingRate>))]
        [JsonInclude]
        public ExpandableField<ShippingRate> InternalShippingRate { get; private set; }
        #endregion

        /// <summary>
        /// The taxes applied to the shipping rate.
        /// </summary>
        [JsonPropertyName("taxes")]
        public List<SessionShippingCostTax> Taxes { get; set; }
    }
}
