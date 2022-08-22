// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SourceSourceOrderOptions : INestedOptions
    {
        /// <summary>
        /// List of items constituting the order.
        /// </summary>
        [JsonPropertyName("items")]
        public List<SourceSourceOrderItemOptions> Items { get; set; }

        /// <summary>
        /// Shipping address for the order. Required if any of the SKUs are for products that have
        /// <c>shippable</c> set to true.
        /// </summary>
        [JsonPropertyName("shipping")]
        public ChargeShippingOptions Shipping { get; set; }
    }
}
