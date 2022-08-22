// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsAfterpayClearpay : StripeEntity<ChargePaymentMethodDetailsAfterpayClearpay>
    {
        /// <summary>
        /// Order identifier shown to the merchant in Afterpay’s online portal.
        /// </summary>
        [JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
