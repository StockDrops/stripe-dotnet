// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsKonbini : StripeEntity<ChargePaymentMethodDetailsKonbini>
    {
        /// <summary>
        /// If the payment succeeded, this contains the details of the convenience store where the
        /// payment was completed.
        /// </summary>
        [JsonPropertyName("store")]
        public ChargePaymentMethodDetailsKonbiniStore Store { get; set; }
    }
}
