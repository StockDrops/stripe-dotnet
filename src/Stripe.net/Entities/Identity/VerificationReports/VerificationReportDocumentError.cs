// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Text.Json.Serialization;

    public class VerificationReportDocumentError : StripeEntity<VerificationReportDocumentError>
    {
        /// <summary>
        /// A short machine-readable string giving the reason for the verification failure.
        /// One of: <c>document_expired</c>, <c>document_type_not_supported</c>, or
        /// <c>document_unverified_other</c>.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// A human-readable message giving the reason for the failure. These messages can be shown
        /// to your users.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
