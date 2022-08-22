// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceSepaDebit : StripeEntity<SourceSepaDebit>
    {
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        [JsonPropertyName("branch_code")]
        public string BranchCode { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonPropertyName("mandate_reference")]
        public string MandateReference { get; set; }

        [JsonPropertyName("mandate_url")]
        public string MandateUrl { get; set; }
    }
}
