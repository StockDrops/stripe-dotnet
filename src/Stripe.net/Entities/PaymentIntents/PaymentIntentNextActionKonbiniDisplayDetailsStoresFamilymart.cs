// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentNextActionKonbiniDisplayDetailsStoresFamilymart : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetailsStoresFamilymart>
    {
        /// <summary>
        /// The confirmation number.
        /// </summary>
        [JsonPropertyName("confirmation_number")]
        public string ConfirmationNumber { get; set; }

        /// <summary>
        /// The payment code.
        /// </summary>
        [JsonPropertyName("payment_code")]
        public string PaymentCode { get; set; }
    }
}
