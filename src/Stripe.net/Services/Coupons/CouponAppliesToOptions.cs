// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class CouponAppliesToOptions : INestedOptions
    {
        /// <summary>
        /// An array of Product IDs that this Coupon will apply to.
        /// </summary>
        [JsonPropertyName("products")]
        public List<string> Products { get; set; }
    }
}
