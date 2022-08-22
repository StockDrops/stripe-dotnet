// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class MandatePaymentMethodDetailsSepaDebit : StripeEntity<MandatePaymentMethodDetailsSepaDebit>
    {
        /// <summary>
        /// The unique reference of the mandate.
        /// </summary>
        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The URL of the mandate. This URL generally contains sensitive information about the
        /// customer and should be shared with them exclusively.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
