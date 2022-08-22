namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class TaxRatePercentageRangeOptions : INestedOptions
    {
        [JsonPropertyName("gt")]
        [AllowNameMismatch]
        public decimal? GreaterThan { get; set; }

        [JsonPropertyName("gte")]
        [AllowNameMismatch]
        public decimal? GreaterThanOrEqual { get; set; }

        [JsonPropertyName("lt")]
        [AllowNameMismatch]
        public decimal? LessThan { get; set; }

        [JsonPropertyName("lte")]
        [AllowNameMismatch]
        public decimal? LessThanOrEqual { get; set; }
    }
}
