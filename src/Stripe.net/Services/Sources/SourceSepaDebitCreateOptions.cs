namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceSepaDebitCreateOptions : INestedOptions
    {
        [JsonPropertyName("iban")]
        public string Iban { get; set; }

        [JsonPropertyName("ideal")]
        public string Ideal { get; set; }
    }
}
