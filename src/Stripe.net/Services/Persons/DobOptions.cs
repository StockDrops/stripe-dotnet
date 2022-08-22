namespace Stripe
{
    using System.Text.Json.Serialization;

    public class DobOptions : INestedOptions
    {
        [JsonPropertyName("day")]
        public long? Day { get; set; }

        [JsonPropertyName("month")]
        public long? Month { get; set; }

        [JsonPropertyName("year")]
        public long? Year { get; set; }
    }
}
