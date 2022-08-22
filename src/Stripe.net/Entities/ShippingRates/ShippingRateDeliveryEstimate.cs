// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ShippingRateDeliveryEstimate : StripeEntity<ShippingRateDeliveryEstimate>
    {
        /// <summary>
        /// The upper bound of the estimated range. If empty, represents no upper bound i.e.,
        /// infinite.
        /// </summary>
        [JsonPropertyName("maximum")]
        public ShippingRateDeliveryEstimateMaximum Maximum { get; set; }

        /// <summary>
        /// The lower bound of the estimated range. If empty, represents no lower bound.
        /// </summary>
        [JsonPropertyName("minimum")]
        public ShippingRateDeliveryEstimateMinimum Minimum { get; set; }
    }
}
