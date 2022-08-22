namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceSofortCreateOptions : INestedOptions
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
