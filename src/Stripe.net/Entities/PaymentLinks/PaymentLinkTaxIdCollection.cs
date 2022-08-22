// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkTaxIdCollection : StripeEntity<PaymentLinkTaxIdCollection>
    {
        /// <summary>
        /// Indicates whether tax ID collection is enabled for the session.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
