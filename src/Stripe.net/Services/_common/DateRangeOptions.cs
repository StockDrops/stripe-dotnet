namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class DateRangeOptions : INestedOptions
    {
        [JsonPropertyName("gt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? GreaterThan { get; set; }

        [JsonPropertyName("gte")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? GreaterThanOrEqual { get; set; }

        [JsonPropertyName("lt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? LessThan { get; set; }

        [JsonPropertyName("lte")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? LessThanOrEqual { get; set; }
    }
}
