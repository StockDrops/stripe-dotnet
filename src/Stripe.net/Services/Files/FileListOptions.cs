// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class FileListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("purpose")]
        public string Purpose { get; set; }
    }
}
