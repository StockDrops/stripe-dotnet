// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsMultibanco : StripeEntity<ChargePaymentMethodDetailsMultibanco>
    {
        /// <summary>
        /// Entity number associated with this Multibanco payment.
        /// </summary>
        [JsonPropertyName("entity")]
        public string Entity { get; set; }

        /// <summary>
        /// Reference number associated with this Multibanco payment.
        /// </summary>
        [JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
