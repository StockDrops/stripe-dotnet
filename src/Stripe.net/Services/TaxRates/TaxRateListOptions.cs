// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class TaxRateListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("inclusive")]
        public bool? Inclusive { get; set; }
    }
}
