// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PlanListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("product")]
        public string Product { get; set; }
    }
}
