namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class BankAccountCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, SourceBankAccount> Source { get; set; }
    }
}
