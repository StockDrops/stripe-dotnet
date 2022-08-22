namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure.JsonConverters;

    public class PackageDimensions : StripeEntity<PackageDimensions>
    {
        [JsonPropertyName("height")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? Height { get; set; }

        [JsonPropertyName("length")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? Length { get; set; }

        [JsonPropertyName("weight")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? Weight { get; set; }

        [JsonPropertyName("width")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? Width { get; set; }
    }
}
