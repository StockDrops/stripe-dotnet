// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PromotionCodeRestrictionsCurrencyOptions : StripeEntity<PromotionCodeRestrictionsCurrencyOptions>
    {
        /// <summary>
        /// Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase
        /// must be $100 or more to work).
        /// </summary>
        [JsonPropertyName("minimum_amount")]
        public long MinimumAmount { get; set; }
    }
}
