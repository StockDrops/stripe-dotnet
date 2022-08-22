// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class QuoteComputedRecurringTotalDetailsBreakdownDiscount : StripeEntity<QuoteComputedRecurringTotalDetailsBreakdownDiscount>
    {
        /// <summary>
        /// The amount discounted.
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// A discount represents the actual application of a <a
        /// href="https://stripe.com/docs/api#coupons">coupon</a> or <a
        /// href="https://stripe.com/docs/api#promotion_codes">promotion code</a>. It contains
        /// information about when the discount began, when it will end, and what it is applied to.
        ///
        /// Related guide: <a
        /// href="https://stripe.com/docs/billing/subscriptions/discounts">Applying Discounts to
        /// Subscriptions</a>.
        /// </summary>
        [JsonPropertyName("discount")]
        public Discount Discount { get; set; }
    }
}
