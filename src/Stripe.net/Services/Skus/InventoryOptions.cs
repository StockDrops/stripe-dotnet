namespace Stripe
{
    using System.Text.Json.Serialization;

    public class InventoryOptions : INestedOptions
    {
        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
