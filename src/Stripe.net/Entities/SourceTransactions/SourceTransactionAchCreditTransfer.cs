namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceTransactionAchCreditTransfer : StripeEntity<SourceTransactionAchCreditTransfer>
    {
        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
