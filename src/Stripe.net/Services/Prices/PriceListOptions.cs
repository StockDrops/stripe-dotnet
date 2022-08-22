// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PriceListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("lookup_keys")]
        public List<string> LookupKeys { get; set; }

        [JsonPropertyName("product")]
        public string Product { get; set; }

        [JsonPropertyName("recurring")]
        public PriceRecurringListOptions Recurring { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
