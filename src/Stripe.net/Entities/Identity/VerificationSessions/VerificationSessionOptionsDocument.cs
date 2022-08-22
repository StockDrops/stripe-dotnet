// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class VerificationSessionOptionsDocument : StripeEntity<VerificationSessionOptionsDocument>
    {
        /// <summary>
        /// Array of strings of allowed identity document types. If the provided identity document
        /// isn’t one of the allowed types, the verification check will fail with a
        /// document_type_not_allowed error code.
        /// </summary>
        [JsonPropertyName("allowed_types")]
        public List<string> AllowedTypes { get; set; }

        /// <summary>
        /// Collect an ID number and perform an <a
        /// href="https://stripe.com/docs/identity/verification-checks?type=id-number">ID number
        /// check</a> with the document’s extracted name and date of birth.
        /// </summary>
        [JsonPropertyName("require_id_number")]
        public bool RequireIdNumber { get; set; }

        /// <summary>
        /// Disable image uploads, identity document images have to be captured using the device’s
        /// camera.
        /// </summary>
        [JsonPropertyName("require_live_capture")]
        public bool RequireLiveCapture { get; set; }

        /// <summary>
        /// Capture a face image and perform a <a
        /// href="https://stripe.com/docs/identity/verification-checks?type=selfie">selfie check</a>
        /// comparing a photo ID and a picture of your user’s face. <a
        /// href="https://stripe.com/docs/identity/selfie">Learn more</a>.
        /// </summary>
        [JsonPropertyName("require_matching_selfie")]
        public bool RequireMatchingSelfie { get; set; }
    }
}
