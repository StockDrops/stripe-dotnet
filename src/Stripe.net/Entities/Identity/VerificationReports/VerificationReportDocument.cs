// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class VerificationReportDocument : StripeEntity<VerificationReportDocument>
    {
        /// <summary>
        /// Address as it appears in the document.
        /// </summary>
        [JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Date of birth as it appears in the document.
        /// </summary>
        [JsonPropertyName("dob")]
        public VerificationReportDocumentDob Dob { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonPropertyName("error")]
        public VerificationReportDocumentError Error { get; set; }

        /// <summary>
        /// Expiration date of the document.
        /// </summary>
        [JsonPropertyName("expiration_date")]
        public VerificationReportDocumentExpirationDate ExpirationDate { get; set; }

        /// <summary>
        /// Array of <a href="https://stripe.com/docs/api/files">File</a> ids containing images for
        /// this document.
        /// </summary>
        [JsonPropertyName("files")]
        public List<string> Files { get; set; }

        /// <summary>
        /// First name as it appears in the document.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Issued date of the document.
        /// </summary>
        [JsonPropertyName("issued_date")]
        public VerificationReportDocumentIssuedDate IssuedDate { get; set; }

        /// <summary>
        /// Issuing country of the document.
        /// </summary>
        [JsonPropertyName("issuing_country")]
        public string IssuingCountry { get; set; }

        /// <summary>
        /// Last name as it appears in the document.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Document ID number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Status of this <c>document</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of the document.
        /// One of: <c>driving_license</c>, <c>id_card</c>, or <c>passport</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
