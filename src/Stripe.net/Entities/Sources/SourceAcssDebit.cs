// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceAcssDebit : StripeEntity<SourceAcssDebit>
    {
        [JsonPropertyName("bank_address_city")]
        public string BankAddressCity { get; set; }

        [JsonPropertyName("bank_address_line_1")]
        public string BankAddressLine1 { get; set; }

        [JsonPropertyName("bank_address_line_2")]
        public string BankAddressLine2 { get; set; }

        [JsonPropertyName("bank_address_postal_code")]
        public string BankAddressPostalCode { get; set; }

        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
