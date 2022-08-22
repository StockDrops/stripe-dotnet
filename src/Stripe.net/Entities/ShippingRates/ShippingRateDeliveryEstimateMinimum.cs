// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ShippingRateDeliveryEstimateMinimum : StripeEntity<ShippingRateDeliveryEstimateMinimum>
    {
        /// <summary>
        /// A unit of time.
        /// One of: <c>business_day</c>, <c>day</c>, <c>hour</c>, <c>month</c>, or <c>week</c>.
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Must be greater than 0.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }
    }
}
