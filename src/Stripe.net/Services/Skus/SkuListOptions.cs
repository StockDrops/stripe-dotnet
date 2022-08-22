// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SkuListOptions : ListOptions
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        [JsonPropertyName("ids")]
        public List<string> Ids { get; set; }

        [JsonPropertyName("in_stock")]
        public bool? InStock { get; set; }

        [JsonPropertyName("product")]
        public string Product { get; set; }
    }
}
