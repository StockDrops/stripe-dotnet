// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System.Text.Json.Serialization;

    public class SecretListOptions : ListOptions
    {
        [JsonPropertyName("scope")]
        public SecretScopeOptions Scope { get; set; }
    }
}
