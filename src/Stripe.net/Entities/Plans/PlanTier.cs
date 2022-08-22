// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure.JsonConverters;

    public class PlanTier : StripeEntity<PlanTier>
    {
        /// <summary>
        /// Price for the entire tier.
        /// </summary>
        [JsonPropertyName("flat_amount")]
        public long? FlatAmount { get; set; }

        /// <summary>
        /// Same as <c>flat_amount</c>, but contains a decimal value with at most 12 decimal places.
        /// </summary>
        [JsonPropertyName("flat_amount_decimal")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? FlatAmountDecimal { get; set; }

        /// <summary>
        /// Per unit price for units relevant to the tier.
        /// </summary>
        [JsonPropertyName("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but contains a decimal value with at most 12 decimal places.
        /// </summary>
        [JsonPropertyName("unit_amount_decimal")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? UnitAmountDecimal { get; set; }

        /// <summary>
        /// Up to and including to this quantity will be contained in the tier.
        /// </summary>
        [JsonPropertyName("up_to")]
        public long? UpTo { get; set; }
    }
}
