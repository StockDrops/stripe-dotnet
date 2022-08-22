namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceBancontactCreateOptions : INestedOptions
    {
        [JsonPropertyName("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}
