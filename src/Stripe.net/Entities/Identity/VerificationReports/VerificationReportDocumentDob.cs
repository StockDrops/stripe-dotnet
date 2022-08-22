// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Text.Json.Serialization;

    public class VerificationReportDocumentDob : StripeEntity<VerificationReportDocumentDob>
    {
        /// <summary>
        /// Numerical day between 1 and 31.
        /// </summary>
        [JsonPropertyName("day")]
        public long? Day { get; set; }

        /// <summary>
        /// Numerical month between 1 and 12.
        /// </summary>
        [JsonPropertyName("month")]
        public long? Month { get; set; }

        /// <summary>
        /// The four-digit year.
        /// </summary>
        [JsonPropertyName("year")]
        public long? Year { get; set; }
    }
}
