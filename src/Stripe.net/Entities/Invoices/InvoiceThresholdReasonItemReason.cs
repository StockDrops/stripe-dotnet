// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class InvoiceThresholdReasonItemReason : StripeEntity<InvoiceThresholdReasonItemReason>
    {
        /// <summary>
        /// The IDs of the line items that triggered the threshold invoice.
        /// </summary>
        [JsonPropertyName("line_item_ids")]
        public List<string> LineItemIds { get; set; }

        /// <summary>
        /// The quantity threshold boundary that applied to the given line item.
        /// </summary>
        [JsonPropertyName("usage_gte")]
        public long UsageGte { get; set; }
    }
}
