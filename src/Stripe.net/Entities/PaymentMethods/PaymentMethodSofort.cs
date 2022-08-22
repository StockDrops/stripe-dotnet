// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentMethodSofort : StripeEntity<PaymentMethodSofort>
    {
        /// <summary>
        /// Two-letter ISO code representing the country the bank account is located in.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
