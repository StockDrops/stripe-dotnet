namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PackageDimensionOptions : INestedOptions
    {
        [JsonPropertyName("height")]
        public decimal? Height { get; set; }

        [JsonPropertyName("length")]
        public decimal? Length { get; set; }

        [JsonPropertyName("weight")]
        public decimal? Weight { get; set; }

        [JsonPropertyName("width")]
        public decimal? Width { get; set; }
    }
}
