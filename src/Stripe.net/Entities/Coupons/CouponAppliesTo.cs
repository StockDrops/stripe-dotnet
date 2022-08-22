// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class CouponAppliesTo : StripeEntity<CouponAppliesTo>
    {
        /// <summary>
        /// A list of product IDs this coupon applies to.
        /// </summary>
        [JsonPropertyName("products")]
        public List<string> Products { get; set; }
    }
}
