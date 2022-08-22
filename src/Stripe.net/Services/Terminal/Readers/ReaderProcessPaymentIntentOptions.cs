// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    public class ReaderProcessPaymentIntentOptions : BaseOptions
    {
        /// <summary>
        /// PaymentIntent ID.
        /// </summary>
        [JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Configuration overrides.
        /// </summary>
        [JsonPropertyName("process_config")]
        public ReaderProcessConfigOptions ProcessConfig { get; set; }
    }
}
