// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentMethodListOptions : ListOptions
    {
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
