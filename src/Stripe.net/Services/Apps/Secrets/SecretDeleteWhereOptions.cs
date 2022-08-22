// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System.Text.Json.Serialization;

    public class SecretDeleteWhereOptions : BaseOptions
    {
        /// <summary>
        /// A name for the secret that's unique within the scope.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the scoping of the secret. Requests originating from UI extensions can only
        /// access account-scoped secrets or secrets scoped to their own user.
        /// </summary>
        [JsonPropertyName("scope")]
        public SecretScopeOptions Scope { get; set; }
    }
}
