// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargeLevel3LineItemOptions : INestedOptions
    {
        [JsonPropertyName("discount_amount")]
        public long? DiscountAmount { get; set; }

        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        [JsonPropertyName("product_description")]
        public string ProductDescription { get; set; }

        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        [JsonPropertyName("tax_amount")]
        public long? TaxAmount { get; set; }

        [JsonPropertyName("unit_cost")]
        public long? UnitCost { get; set; }
    }
}
