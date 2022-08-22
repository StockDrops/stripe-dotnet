// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ShippingRateListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
