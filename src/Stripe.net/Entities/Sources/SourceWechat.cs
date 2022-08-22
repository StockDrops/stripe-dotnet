// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceWechat : StripeEntity<SourceWechat>
    {
        [JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; }

        [JsonPropertyName("qr_code_url")]
        public string QrCodeUrl { get; set; }

        [JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
