// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionTaxIdCollection : StripeEntity<SessionTaxIdCollection>
    {
        /// <summary>
        /// Indicates whether tax ID collection is enabled for the session.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
