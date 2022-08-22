namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class InvoiceListLineItemsOptions : ListOptions
    {
        [JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("subscription")]
        public string Subscription { get; set; }

        [JsonPropertyName("subscription_items")]
        public List<InvoiceSubscriptionItemOptions> SubscriptionItems { get; set; }

        [JsonPropertyName("subscription_plan")]
        public string SubscriptionPlan { get; set; }
    }
}
