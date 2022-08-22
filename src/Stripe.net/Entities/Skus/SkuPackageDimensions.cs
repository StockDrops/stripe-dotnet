// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SkuPackageDimensions : StripeEntity<SkuPackageDimensions>
    {
        /// <summary>
        /// Height, in inches.
        /// </summary>
        [JsonPropertyName("height")]
        public decimal Height { get; set; }

        /// <summary>
        /// Length, in inches.
        /// </summary>
        [JsonPropertyName("length")]
        public decimal Length { get; set; }

        /// <summary>
        /// Weight, in ounces.
        /// </summary>
        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }

        /// <summary>
        /// Width, in inches.
        /// </summary>
        [JsonPropertyName("width")]
        public decimal Width { get; set; }
    }
}
