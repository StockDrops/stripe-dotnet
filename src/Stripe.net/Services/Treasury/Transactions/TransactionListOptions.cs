// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class TransactionListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        [JsonPropertyName("order_by")]
        public string OrderBy { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("status_transitions")]
        public TransactionStatusTransitionsOptions StatusTransitions { get; set; }
    }
}
