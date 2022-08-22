// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class QuoteComputedUpfrontTotalDetailsBreakdown : StripeEntity<QuoteComputedUpfrontTotalDetailsBreakdown>
    {
        /// <summary>
        /// The aggregated discounts.
        /// </summary>
        [JsonPropertyName("discounts")]
        public List<QuoteComputedUpfrontTotalDetailsBreakdownDiscount> Discounts { get; set; }

        /// <summary>
        /// The aggregated tax amounts by rate.
        /// </summary>
        [JsonPropertyName("taxes")]
        public List<QuoteComputedUpfrontTotalDetailsBreakdownTax> Taxes { get; set; }
    }
}
