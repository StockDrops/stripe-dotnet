// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodOptionsLinkOptions : INestedOptions
    {
        /// <summary>
        /// Token used for persistent Link logins.
        /// </summary>
        [JsonPropertyName("persistent_token")]
        public string PersistentToken { get; set; }
    }
}
