// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionAfterExpirationOptions : INestedOptions
    {
        /// <summary>
        /// Configure a Checkout Session that can be used to recover an expired session.
        /// </summary>
        [JsonPropertyName("recovery")]
        public SessionAfterExpirationRecoveryOptions Recovery { get; set; }
    }
}
