// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System.Text.Json.Serialization;

    public class SecretScopeOptions : INestedOptions
    {
        /// <summary>
        /// The secret scope type.
        /// One of: <c>account</c>, or <c>user</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The user ID. This field is required if <c>type</c> is set to <c>user</c>, and should not
        /// be provided if <c>type</c> is set to <c>account</c>.
        /// </summary>
        [JsonPropertyName("user")]
        public string User { get; set; }
    }
}
