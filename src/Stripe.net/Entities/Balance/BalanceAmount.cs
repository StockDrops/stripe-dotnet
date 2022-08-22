namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class BalanceAmount : StripeEntity<BalanceAmount>
    {
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("source_types")]
        public Dictionary<string, long> SourceTypes { get; set; }
    }
}
