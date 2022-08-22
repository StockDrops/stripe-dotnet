// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionConsent : StripeEntity<SessionConsent>
    {
        /// <summary>
        /// If <c>opt_in</c>, the customer consents to receiving promotional communications from the
        /// merchant about this Checkout Session.
        /// One of: <c>opt_in</c>, or <c>opt_out</c>.
        /// </summary>
        [JsonPropertyName("promotions")]
        public string Promotions { get; set; }
    }
}
