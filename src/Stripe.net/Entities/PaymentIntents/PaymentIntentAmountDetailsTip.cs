// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentAmountDetailsTip : StripeEntity<PaymentIntentAmountDetailsTip>
    {
        /// <summary>
        /// Portion of the amount that corresponds to a tip.
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }
    }
}
