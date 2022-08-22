// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsOxxo : StripeEntity<ChargePaymentMethodDetailsOxxo>
    {
        /// <summary>
        /// OXXO reference number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
