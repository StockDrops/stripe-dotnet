// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PromotionCodeListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        [JsonPropertyName("customer")]
        public string Customer { get; set; }
    }
}
