// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class DisputeListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("transaction")]
        public string Transaction { get; set; }
    }
}
