namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;
    using Stripe.Infrastructure.JsonConverters;

    public class ReviewLocation : StripeEntity<ReviewLocation>
    {
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("latitude")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? Latitude { get; set; }

        [JsonPropertyName("longitude")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? Longitude { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }
    }
}
