namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PriceTransformUsageOptions : INestedOptions
    {
        [JsonPropertyName("divide_by")]
        public long? DivideBy { get; set; }

        [JsonPropertyName("round")]
        public string Round { get; set; }
    }
}
