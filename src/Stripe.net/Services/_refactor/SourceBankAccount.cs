namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SourceBankAccount : INestedOptions, IHasMetadata
    {
        [JsonPropertyName("object")]
        internal string Object => "bank_account";

        [JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        [JsonPropertyName("account_holder_type")]
        public string AccountHolderType { get; set; }

        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
