namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceIdealCreateOptions : INestedOptions
    {
        [JsonPropertyName("bank")]
        public string Bank { get; set; }
    }
}
