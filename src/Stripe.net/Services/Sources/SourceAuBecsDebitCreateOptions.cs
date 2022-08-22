namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceAuBecsDebitCreateOptions : INestedOptions
    {
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("bsb_number")]
        public string BsbNumber { get; set; }
    }
}
