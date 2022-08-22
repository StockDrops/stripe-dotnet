// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EventListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("delivery_success")]
        public bool? DeliverySuccess { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("types")]
        public List<string> Types { get; set; }
    }
}
