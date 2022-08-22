namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SourceAttachOptions : BaseOptions
    {
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("validate")]
        public bool? Validate { get; set; }
    }
}
