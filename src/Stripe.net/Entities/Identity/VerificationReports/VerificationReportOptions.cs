// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Text.Json.Serialization;

    public class VerificationReportOptions : StripeEntity<VerificationReportOptions>
    {
        [JsonPropertyName("document")]
        public VerificationReportOptionsDocument Document { get; set; }

        [JsonPropertyName("id_number")]
        public VerificationReportOptionsIdNumber IdNumber { get; set; }
    }
}
