// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CustomerListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("test_clock")]
        public string TestClock { get; set; }
    }
}
