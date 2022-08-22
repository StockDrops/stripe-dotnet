// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentMethodKlarna : StripeEntity<PaymentMethodKlarna>
    {
        /// <summary>
        /// The customer's date of birth, if provided.
        /// </summary>
        [JsonPropertyName("dob")]
        public PaymentMethodKlarnaDob Dob { get; set; }
    }
}
