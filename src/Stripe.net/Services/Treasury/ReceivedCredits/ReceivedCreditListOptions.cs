// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class ReceivedCreditListOptions : ListOptions
    {
        [JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        [JsonPropertyName("linked_flows")]
        public ReceivedCreditLinkedFlowsOptions LinkedFlows { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
