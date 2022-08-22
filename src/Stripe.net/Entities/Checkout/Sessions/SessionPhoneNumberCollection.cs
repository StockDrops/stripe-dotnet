// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionPhoneNumberCollection : StripeEntity<SessionPhoneNumberCollection>
    {
        /// <summary>
        /// Indicates whether phone number collection is enabled for the session.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
