namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceListOptions : ListOptions
    {
        [JsonPropertyName("object")]
        internal string Object => "source";

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
