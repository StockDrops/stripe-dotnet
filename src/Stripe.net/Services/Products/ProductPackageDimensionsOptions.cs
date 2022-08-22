// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ProductPackageDimensionsOptions : INestedOptions
    {
        /// <summary>
        /// Height, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonPropertyName("height")]
        public decimal? Height { get; set; }

        /// <summary>
        /// Length, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonPropertyName("length")]
        public decimal? Length { get; set; }

        /// <summary>
        /// Weight, in ounces. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonPropertyName("weight")]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Width, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonPropertyName("width")]
        public decimal? Width { get; set; }
    }
}
