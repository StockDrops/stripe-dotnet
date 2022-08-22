// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class DebitReversalListOptions : ListOptions
    {
        [JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        [JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }

        [JsonPropertyName("resolution")]
        public string Resolution { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
