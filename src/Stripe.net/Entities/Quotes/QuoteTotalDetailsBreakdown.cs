// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class QuoteTotalDetailsBreakdown : StripeEntity<QuoteTotalDetailsBreakdown>
    {
        /// <summary>
        /// The aggregated discounts.
        /// </summary>
        [JsonPropertyName("discounts")]
        public List<QuoteTotalDetailsBreakdownDiscount> Discounts { get; set; }

        /// <summary>
        /// The aggregated tax amounts by rate.
        /// </summary>
        [JsonPropertyName("taxes")]
        public List<QuoteTotalDetailsBreakdownTax> Taxes { get; set; }
    }
}
