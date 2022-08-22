// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    public class ReaderListOptions : ListOptions
    {
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
