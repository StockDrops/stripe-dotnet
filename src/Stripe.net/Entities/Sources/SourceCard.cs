// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceCard : StripeEntity<SourceCard>
    {
        [JsonPropertyName("address_line1_check")]
        public string AddressLine1Check { get; set; }

        [JsonPropertyName("address_zip_check")]
        public string AddressZipCheck { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("cvc_check")]
        public string CvcCheck { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        [JsonPropertyName("exp_month")]
        public long ExpMonth { get; set; }

        [JsonPropertyName("exp_year")]
        public long ExpYear { get; set; }

        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonPropertyName("funding")]
        public string Funding { get; set; }

        [JsonPropertyName("iin")]
        public string Iin { get; set; }

        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("three_d_secure")]
        public string ThreeDSecure { get; set; }

        [JsonPropertyName("tokenization_method")]
        public string TokenizationMethod { get; set; }
    }
}
