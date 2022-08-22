// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System.Text.Json.Serialization;

    public class SecretFindOptions : BaseOptions
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("scope")]
        public SecretScopeOptions Scope { get; set; }
    }
}
