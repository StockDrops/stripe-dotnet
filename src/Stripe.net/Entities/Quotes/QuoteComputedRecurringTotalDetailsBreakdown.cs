// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class QuoteComputedRecurringTotalDetailsBreakdown : StripeEntity<QuoteComputedRecurringTotalDetailsBreakdown>
    {
        /// <summary>
        /// The aggregated discounts.
        /// </summary>
        [JsonPropertyName("discounts")]
        public List<QuoteComputedRecurringTotalDetailsBreakdownDiscount> Discounts { get; set; }

        /// <summary>
        /// The aggregated tax amounts by rate.
        /// </summary>
        [JsonPropertyName("taxes")]
        public List<QuoteComputedRecurringTotalDetailsBreakdownTax> Taxes { get; set; }
    }
}
