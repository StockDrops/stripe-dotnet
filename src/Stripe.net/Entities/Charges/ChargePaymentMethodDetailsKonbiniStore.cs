// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsKonbiniStore : StripeEntity<ChargePaymentMethodDetailsKonbiniStore>
    {
        /// <summary>
        /// The name of the convenience store chain where the payment was completed.
        /// One of: <c>familymart</c>, <c>lawson</c>, <c>ministop</c>, or <c>seicomart</c>.
        /// </summary>
        [JsonPropertyName("chain")]
        public string Chain { get; set; }
    }
}
