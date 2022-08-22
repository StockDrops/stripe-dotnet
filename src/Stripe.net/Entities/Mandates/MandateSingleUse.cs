// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class MandateSingleUse : StripeEntity<MandateSingleUse>
    {
        /// <summary>
        /// On a single use mandate, the amount of the payment.
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// On a single use mandate, the currency of the payment.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
