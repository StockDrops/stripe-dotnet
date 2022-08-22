// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentMethodLink : StripeEntity<PaymentMethodLink>
    {
        /// <summary>
        /// Account owner's email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Token used for persistent Link logins.
        /// </summary>
        [JsonPropertyName("persistent_token")]
        public string PersistentToken { get; set; }
    }
}
