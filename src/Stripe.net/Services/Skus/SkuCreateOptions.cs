// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SkuCreateOptions : BaseOptions, IHasId, IHasMetadata
    {
        /// <summary>
        /// Whether the SKU is available for purchase. Default to <c>true</c>.
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A dictionary of attributes and values for the attributes defined by the product. If, for
        /// example, a product's attributes are <c>["size", "gender"]</c>, a valid SKU has the
        /// following dictionary of attributes: <c>{"size": "Medium", "gender": "Unisex"}</c>.
        /// </summary>
        [JsonPropertyName("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The identifier for the SKU. Must be unique. If not provided, an identifier will be
        /// randomly generated.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The URL of an image for this SKU, meant to be displayable to the customer.
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// Description of the SKU's inventory.
        /// </summary>
        [JsonPropertyName("inventory")]
        public SkuInventoryOptions Inventory { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The dimensions of this SKU for shipping purposes.
        /// </summary>
        [JsonPropertyName("package_dimensions")]
        public SkuPackageDimensionsOptions PackageDimensions { get; set; }

        /// <summary>
        /// The cost of the item as a nonnegative integer in the smallest currency unit (that is,
        /// 100 cents to charge $1.00, or 100 to charge ¥100, Japanese Yen being a zero-decimal
        /// currency).
        /// </summary>
        [JsonPropertyName("price")]
        public long? Price { get; set; }

        /// <summary>
        /// The ID of the product this SKU is associated with. Must be a product with type
        /// <c>good</c>.
        /// </summary>
        [JsonPropertyName("product")]
        public string Product { get; set; }
    }
}
