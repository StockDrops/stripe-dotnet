namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceThreeDSecureCreateOptions : INestedOptions
    {
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("card")]
        public string Card { get; set; }
    }
}
