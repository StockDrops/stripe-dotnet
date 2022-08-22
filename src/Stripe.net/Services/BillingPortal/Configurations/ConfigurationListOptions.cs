// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Text.Json.Serialization;

    public class ConfigurationListOptions : ListOptions
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }
    }
}
