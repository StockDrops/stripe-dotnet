// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class OutboundTransferListOptions : ListOptions
    {
        [JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
