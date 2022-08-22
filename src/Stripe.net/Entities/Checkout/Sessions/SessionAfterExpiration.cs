// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionAfterExpiration : StripeEntity<SessionAfterExpiration>
    {
        /// <summary>
        /// When set, configuration used to recover the Checkout Session on expiry.
        /// </summary>
        [JsonPropertyName("recovery")]
        public SessionAfterExpirationRecovery Recovery { get; set; }
    }
}
