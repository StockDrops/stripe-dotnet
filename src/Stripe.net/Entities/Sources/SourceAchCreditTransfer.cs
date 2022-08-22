// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceAchCreditTransfer : StripeEntity<SourceAchCreditTransfer>
    {
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonPropertyName("refund_account_holder_name")]
        public string RefundAccountHolderName { get; set; }

        [JsonPropertyName("refund_account_holder_type")]
        public string RefundAccountHolderType { get; set; }

        [JsonPropertyName("refund_routing_number")]
        public string RefundRoutingNumber { get; set; }

        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }

        [JsonPropertyName("swift_code")]
        public string SwiftCode { get; set; }
    }
}
