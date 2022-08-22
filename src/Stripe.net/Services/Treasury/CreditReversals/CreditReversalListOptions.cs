// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class CreditReversalListOptions : ListOptions
    {
        [JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        [JsonPropertyName("received_credit")]
        public string ReceivedCredit { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
