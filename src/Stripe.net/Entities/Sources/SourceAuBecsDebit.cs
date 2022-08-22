// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceAuBecsDebit : StripeEntity<SourceAuBecsDebit>
    {
        [JsonPropertyName("bsb_number")]
        public string BsbNumber { get; set; }

        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonPropertyName("last4")]
        public string Last4 { get; set; }
    }
}
