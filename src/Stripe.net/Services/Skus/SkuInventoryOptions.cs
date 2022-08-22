// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SkuInventoryOptions : INestedOptions
    {
        /// <summary>
        /// The count of inventory available. Required if <c>type</c> is <c>finite</c>.
        /// </summary>
        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Inventory type. Possible values are <c>finite</c>, <c>bucket</c> (not quantified), and
        /// <c>infinite</c>.
        /// One of: <c>bucket</c>, <c>finite</c>, or <c>infinite</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// An indicator of the inventory available. Possible values are <c>in_stock</c>,
        /// <c>limited</c>, and <c>out_of_stock</c>. Will be present if and only if <c>type</c> is
        /// <c>bucket</c>.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
