// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class TaxIdVerification : StripeEntity<TaxIdVerification>
    {
        /// <summary>
        /// Verification status, one of <c>pending</c>, <c>verified</c>, <c>unverified</c>, or
        /// <c>unavailable</c>.
        /// One of: <c>pending</c>, <c>unavailable</c>, <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Verified address.
        /// </summary>
        [JsonPropertyName("verified_address")]
        public string VerifiedAddress { get; set; }

        /// <summary>
        /// Verified name.
        /// </summary>
        [JsonPropertyName("verified_name")]
        public string VerifiedName { get; set; }
    }
}
