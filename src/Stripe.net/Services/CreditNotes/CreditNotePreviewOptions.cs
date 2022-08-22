// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class CreditNotePreviewOptions : BaseOptions, IHasMetadata
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("credit_amount")]
        public long? CreditAmount { get; set; }

        [JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        [JsonPropertyName("lines")]
        public List<CreditNoteLineOptions> Lines { get; set; }

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
