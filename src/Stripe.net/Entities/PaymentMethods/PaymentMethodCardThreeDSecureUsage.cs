// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentMethodCardThreeDSecureUsage : StripeEntity<PaymentMethodCardThreeDSecureUsage>
    {
        /// <summary>
        /// Whether 3D Secure is supported on this card.
        /// </summary>
        [JsonPropertyName("supported")]
        public bool Supported { get; set; }
    }
}
