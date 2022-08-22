// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System.Text.Json.Serialization;

    public class SecretScope : StripeEntity<SecretScope>
    {
        /// <summary>
        /// The secret scope type.
        /// One of: <c>account</c>, or <c>user</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The user ID, if type is set to "user".
        /// </summary>
        [JsonPropertyName("user")]
        public string User { get; set; }
    }
}
