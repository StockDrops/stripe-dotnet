// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionTotalDetails : StripeEntity<SessionTotalDetails>
    {
        /// <summary>
        /// This is the sum of all the discounts.
        /// </summary>
        [JsonPropertyName("amount_discount")]
        public long AmountDiscount { get; set; }

        /// <summary>
        /// This is the sum of all the shipping amounts.
        /// </summary>
        [JsonPropertyName("amount_shipping")]
        public long? AmountShipping { get; set; }

        /// <summary>
        /// This is the sum of all the tax amounts.
        /// </summary>
        [JsonPropertyName("amount_tax")]
        public long AmountTax { get; set; }

        [JsonPropertyName("breakdown")]
        public SessionTotalDetailsBreakdown Breakdown { get; set; }
    }
}
