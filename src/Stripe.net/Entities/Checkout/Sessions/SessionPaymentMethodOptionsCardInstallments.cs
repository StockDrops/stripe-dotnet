// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionPaymentMethodOptionsCardInstallments : StripeEntity<SessionPaymentMethodOptionsCardInstallments>
    {
        /// <summary>
        /// Indicates if installments are enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
