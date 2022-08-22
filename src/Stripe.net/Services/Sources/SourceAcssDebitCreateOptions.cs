namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceAcssDebitCreateOptions : INestedOptions
    {
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
