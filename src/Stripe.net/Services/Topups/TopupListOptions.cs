// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class TopupListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
