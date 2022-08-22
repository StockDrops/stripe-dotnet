// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Text.Json.Serialization;

    public class VerificationSessionRedaction : StripeEntity<VerificationSessionRedaction>
    {
        /// <summary>
        /// Indicates whether this object and its related objects have been redacted or not.
        /// One of: <c>processing</c>, or <c>redacted</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
