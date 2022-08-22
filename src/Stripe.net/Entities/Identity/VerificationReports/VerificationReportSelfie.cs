// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Text.Json.Serialization;

    public class VerificationReportSelfie : StripeEntity<VerificationReportSelfie>
    {
        /// <summary>
        /// ID of the <a href="https://stripe.com/docs/api/files">File</a> holding the image of the
        /// identity document used in this check.
        /// </summary>
        [JsonPropertyName("document")]
        public string Document { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonPropertyName("error")]
        public VerificationReportSelfieError Error { get; set; }

        /// <summary>
        /// ID of the <a href="https://stripe.com/docs/api/files">File</a> holding the image of the
        /// selfie used in this check.
        /// </summary>
        [JsonPropertyName("selfie")]
        public string Selfie { get; set; }

        /// <summary>
        /// Status of this <c>selfie</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
