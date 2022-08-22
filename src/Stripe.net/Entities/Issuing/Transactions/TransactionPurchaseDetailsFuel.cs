// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class TransactionPurchaseDetailsFuel : StripeEntity<TransactionPurchaseDetailsFuel>
    {
        /// <summary>
        /// The type of fuel that was purchased. One of <c>diesel</c>, <c>unleaded_plus</c>,
        /// <c>unleaded_regular</c>, <c>unleaded_super</c>, or <c>other</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The units for <c>volume_decimal</c>. One of <c>us_gallon</c> or <c>liter</c>.
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The cost in cents per each unit of fuel, represented as a decimal string with at most 12
        /// decimal places.
        /// </summary>
        [JsonPropertyName("unit_cost_decimal")]
        public decimal UnitCostDecimal { get; set; }

        /// <summary>
        /// The volume of the fuel that was pumped, represented as a decimal string with at most 12
        /// decimal places.
        /// </summary>
        [JsonPropertyName("volume_decimal")]
        public decimal? VolumeDecimal { get; set; }
    }
}
