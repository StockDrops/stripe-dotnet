// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceAlipay : StripeEntity<SourceAlipay>
    {
        [JsonPropertyName("data_string")]
        public string DataString { get; set; }

        [JsonPropertyName("native_url")]
        public string NativeUrl { get; set; }

        [JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
