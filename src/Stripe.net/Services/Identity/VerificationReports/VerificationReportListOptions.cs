// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Text.Json.Serialization;

    public class VerificationReportListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("verification_session")]
        public string VerificationSession { get; set; }
    }
}
