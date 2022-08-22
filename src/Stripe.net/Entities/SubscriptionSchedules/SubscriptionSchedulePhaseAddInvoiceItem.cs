// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhaseAddInvoiceItem : StripeEntity<SubscriptionSchedulePhaseAddInvoiceItem>
    {
        #region Expandable Price

        /// <summary>
        /// (ID of the Price)
        /// ID of the price used to generate the invoice item.
        /// </summary>
        [JsonIgnore]
        public string PriceId
        {
            get => this.InternalPrice?.Id;
            set => this.InternalPrice = SetExpandableFieldId(value, this.InternalPrice);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the price used to generate the invoice item.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Price Price
        {
            get => this.InternalPrice?.ExpandedObject;
            set => this.InternalPrice = SetExpandableFieldObject(value, this.InternalPrice);
        }

        [JsonPropertyName("price")]
        [JsonConverter(typeof(ExpandableFieldConverter<Price>))]
        [JsonInclude]
        public ExpandableField<Price> InternalPrice { get; private set; }
        #endregion

        /// <summary>
        /// The quantity of the invoice item.
        /// </summary>
        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the item. When set, the <c>default_tax_rates</c> do not
        /// apply to this item.
        /// </summary>
        [JsonPropertyName("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }
    }
}
