namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class CreditNoteListPreviewLineItemsOptions : ListOptions, IHasMetadata
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("credit_amount")]
        public long? CreditAmount { get; set; }

        [JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("out_of_band_amount")]
        public long? OutOfBandAmount { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("refund")]
        public string Refund { get; set; }

        [JsonPropertyName("refund_amount")]
        public long? RefundAmount { get; set; }
    }
}
