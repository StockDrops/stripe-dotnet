// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsPaynow : StripeEntity<ChargePaymentMethodDetailsPaynow>
    {
        /// <summary>
        /// Reference number associated with this PayNow payment.
        /// </summary>
        [JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
