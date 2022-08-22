// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SecretCreateOptions : BaseOptions
    {
        /// <summary>
        /// The Unix timestamp for the expiry time of the secret, after which the secret deletes.
        /// </summary>
        [JsonPropertyName("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// A name for the secret that's unique within the scope.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The plaintext secret value to be stored.
        /// </summary>
        [JsonPropertyName("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// Specifies the scoping of the secret. Requests originating from UI extensions can only
        /// access account-scoped secrets or secrets scoped to their own user.
        /// </summary>
        [JsonPropertyName("scope")]
        public SecretScopeOptions Scope { get; set; }
    }
}
