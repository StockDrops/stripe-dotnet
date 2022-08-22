// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionDiscountOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the coupon to apply to this Session.
        /// </summary>
        [JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// The ID of a promotion code to apply to this Session.
        /// </summary>
        [JsonPropertyName("promotion_code")]
        public string PromotionCode { get; set; }
    }
}
