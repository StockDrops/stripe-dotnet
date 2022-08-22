// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    public class ConfigurationListOptions : ListOptions
    {
        [JsonPropertyName("is_account_default")]
        public bool? IsAccountDefault { get; set; }
    }
}
