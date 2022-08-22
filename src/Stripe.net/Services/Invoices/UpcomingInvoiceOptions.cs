namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class UpcomingInvoiceOptions : BaseOptions
    {
        /// <summary>
        /// Settings for automatic tax lookup for this invoice.
        /// </summary>
        [JsonPropertyName("automatic_tax")]
        public InvoiceAutomaticTaxOptions AutomaticTax { get; set; }

        [JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Details about the customer you want to invoice.
        /// </summary>
        [JsonPropertyName("customer_details")]
        public InvoiceCustomerDetailsOptions CustomerDetails { get; set; }

        [JsonPropertyName("discounts")]
        public List<InvoiceDiscountOptions> Discounts { get; set; }

        [JsonPropertyName("invoice_items")]
        public List<InvoiceUpcomingInvoiceItemOptions> InvoiceItems { get; set; }

        [JsonPropertyName("schedule")]
        public string Schedule { get; set; }

        [JsonPropertyName("subscription_billing_cycle_anchor")]
        [JsonConverter(typeof(AnyOfConverterFactory))]
        public AnyOf<DateTime?, SubscriptionBillingCycleAnchor> SubscriptionBillingCycleAnchor { get; set; }

        [JsonPropertyName("subscription_cancel_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SubscriptionCancelAt { get; set; }

        [JsonPropertyName("subscription_cancel_at_period_end")]
        public bool? SubscriptionCancelAtPeriodEnd { get; set; }

        [JsonPropertyName("subscription_cancel_now")]
        public bool? SubscriptionCancelNow { get; set; }

        [JsonPropertyName("subscription_default_tax_rates")]
        public List<string> SubscriptionDefaultTaxRates { get; set; }

        [JsonPropertyName("subscription")]
        public string Subscription { get; set; }

        [JsonPropertyName("subscription_items")]
        public List<InvoiceSubscriptionItemOptions> SubscriptionItems { get; set; }

        [Obsolete("Use SubscriptionProrationBehavior instead.")]
        [JsonPropertyName("subscription_prorate")]
        public bool? SubscriptionProrate { get; set; }

        [JsonPropertyName("subscription_proration_behavior")]
        public string SubscriptionProrationBehavior { get; set; }

        [JsonPropertyName("subscription_proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SubscriptionProrationDate { get; set; }

        [JsonPropertyName("subscription_start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SubscriptionStartDate { get; set; }

        [JsonPropertyName("subscription_trial_end")]
        [JsonConverter(typeof(AnyOfConverterFactory))]
        public AnyOf<DateTime?, SubscriptionTrialEnd> SubscriptionTrialEnd { get; set; }

        [JsonPropertyName("subscription_trial_from_plan")]
        public bool? SubscriptionTrialFromPlan { get; set; }
    }
}
