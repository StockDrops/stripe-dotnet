namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionSchedulePhasePlanPriceDataOptions : INestedOptions
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("product")]
        public string Product { get; set; }

        [JsonPropertyName("recurring")]
        public SubscriptionSchedulePhasePlanPriceDataRecurringOptions Recurring { get; set; }

        [JsonPropertyName("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonPropertyName("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
