// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class QuoteListOptions : ListOptions
    {
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("test_clock")]
        public string TestClock { get; set; }
    }
}
