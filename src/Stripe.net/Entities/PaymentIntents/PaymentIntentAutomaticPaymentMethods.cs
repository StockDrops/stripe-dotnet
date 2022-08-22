// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentAutomaticPaymentMethods : StripeEntity<PaymentIntentAutomaticPaymentMethods>
    {
        /// <summary>
        /// Automatically calculates compatible payment methods.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
