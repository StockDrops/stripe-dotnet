// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class InvoiceThresholdReason : StripeEntity<InvoiceThresholdReason>
    {
        /// <summary>
        /// The total invoice amount threshold boundary if it triggered the threshold invoice.
        /// </summary>
        [JsonPropertyName("amount_gte")]
        public long? AmountGte { get; set; }

        /// <summary>
        /// Indicates which line items triggered a threshold invoice.
        /// </summary>
        [JsonPropertyName("item_reasons")]
        public List<InvoiceThresholdReasonItemReason> ItemReasons { get; set; }
    }
}
