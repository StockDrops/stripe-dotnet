// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceAchDebit : StripeEntity<SourceAchDebit>
    {
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
