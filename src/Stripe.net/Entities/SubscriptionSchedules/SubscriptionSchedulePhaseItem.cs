// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhaseItem : StripeEntity<SubscriptionSchedulePhaseItem>
    {
        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the related subscription
        /// advanced to a new billing period.
        /// </summary>
        [JsonPropertyName("billing_thresholds")]
        public SubscriptionSchedulePhaseItemBillingThresholds BillingThresholds { get; set; }

        #region Expandable Plan

        /// <summary>
        /// (ID of the Plan)
        /// ID of the plan to which the customer should be subscribed.
        /// </summary>
        [JsonIgnore]
        public string PlanId
        {
            get => this.InternalPlan?.Id;
            set => this.InternalPlan = SetExpandableFieldId(value, this.InternalPlan);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the plan to which the customer should be subscribed.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Plan Plan
        {
            get => this.InternalPlan?.ExpandedObject;
            set => this.InternalPlan = SetExpandableFieldObject(value, this.InternalPlan);
        }

        [JsonPropertyName("plan")]
        [JsonConverter(typeof(ExpandableFieldConverter<Plan>))]
        [JsonInclude]
        public ExpandableField<Plan> InternalPlan { get; private set; }
        #endregion

        #region Expandable Price

        /// <summary>
        /// (ID of the Price)
        /// ID of the price to which the customer should be subscribed.
        /// </summary>
        [JsonIgnore]
        public string PriceId
        {
            get => this.InternalPrice?.Id;
            set => this.InternalPrice = SetExpandableFieldId(value, this.InternalPrice);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the price to which the customer should be subscribed.
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
        /// Quantity of the plan to which the customer should be subscribed.
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to this <c>phase_item</c>. When set, the
        /// <c>default_tax_rates</c> on the phase do not apply to this <c>phase_item</c>.
        /// </summary>
        [JsonPropertyName("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }
    }
}
