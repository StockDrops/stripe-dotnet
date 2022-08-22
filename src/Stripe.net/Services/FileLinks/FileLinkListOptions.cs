// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class FileLinkListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("expired")]
        public bool? Expired { get; set; }

        [JsonPropertyName("file")]
        public string File { get; set; }
    }
}
