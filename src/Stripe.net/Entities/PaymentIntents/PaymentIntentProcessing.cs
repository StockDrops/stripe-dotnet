// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentProcessing : StripeEntity<PaymentIntentProcessing>
    {
        [JsonPropertyName("card")]
        public PaymentIntentProcessingCard Card { get; set; }

        /// <summary>
        /// Type of the payment method for which payment is in <c>processing</c> state, one of
        /// <c>card</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
