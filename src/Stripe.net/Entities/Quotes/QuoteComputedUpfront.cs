// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class QuoteComputedUpfront : StripeEntity<QuoteComputedUpfront>
    {
        /// <summary>
        /// Total before any discounts or taxes are applied.
        /// </summary>
        [JsonPropertyName("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total after discounts and taxes are applied.
        /// </summary>
        [JsonPropertyName("amount_total")]
        public long AmountTotal { get; set; }

        /// <summary>
        /// The line items that will appear on the next invoice after this quote is accepted. This
        /// does not include pending invoice items that exist on the customer but may still be
        /// included in the next invoice.
        /// </summary>
        [JsonPropertyName("line_items")]
        public StripeList<LineItem> LineItems { get; set; }

        [JsonPropertyName("total_details")]
        public QuoteComputedUpfrontTotalDetails TotalDetails { get; set; }
    }
}
