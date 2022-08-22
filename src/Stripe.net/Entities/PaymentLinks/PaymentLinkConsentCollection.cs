// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkConsentCollection : StripeEntity<PaymentLinkConsentCollection>
    {
        /// <summary>
        /// If set to <c>auto</c>, enables the collection of customer consent for promotional
        /// communications.
        /// One of: <c>auto</c>, or <c>none</c>.
        /// </summary>
        [JsonPropertyName("promotions")]
        public string Promotions { get; set; }
    }
}
