// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Text.Json.Serialization;

    public class VerificationReportIdNumber : StripeEntity<VerificationReportIdNumber>
    {
        /// <summary>
        /// Date of birth.
        /// </summary>
        [JsonPropertyName("dob")]
        public VerificationReportIdNumberDob Dob { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonPropertyName("error")]
        public VerificationReportIdNumberError Error { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// ID number.
        /// </summary>
        [JsonPropertyName("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// Type of ID number.
        /// One of: <c>br_cpf</c>, <c>sg_nric</c>, or <c>us_ssn</c>.
        /// </summary>
        [JsonPropertyName("id_number_type")]
        public string IdNumberType { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Status of this <c>id_number</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
