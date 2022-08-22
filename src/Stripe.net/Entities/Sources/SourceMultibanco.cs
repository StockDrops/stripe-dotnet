// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceMultibanco : StripeEntity<SourceMultibanco>
    {
        [JsonPropertyName("entity")]
        public string Entity { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("refund_account_holder_address_city")]
        public string RefundAccountHolderAddressCity { get; set; }

        [JsonPropertyName("refund_account_holder_address_country")]
        public string RefundAccountHolderAddressCountry { get; set; }

        [JsonPropertyName("refund_account_holder_address_line1")]
        public string RefundAccountHolderAddressLine1 { get; set; }

        [JsonPropertyName("refund_account_holder_address_line2")]
        public string RefundAccountHolderAddressLine2 { get; set; }

        [JsonPropertyName("refund_account_holder_address_postal_code")]
        public string RefundAccountHolderAddressPostalCode { get; set; }

        [JsonPropertyName("refund_account_holder_address_state")]
        public string RefundAccountHolderAddressState { get; set; }

        [JsonPropertyName("refund_account_holder_name")]
        public string RefundAccountHolderName { get; set; }

        [JsonPropertyName("refund_iban")]
        public string RefundIban { get; set; }
    }
}
