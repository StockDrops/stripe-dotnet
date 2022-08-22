// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Text.Json.Serialization;

    public class VerificationSessionVerifiedOutputs : StripeEntity<VerificationSessionVerifiedOutputs>
    {
        /// <summary>
        /// The user's verified address.
        /// </summary>
        [JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The user’s verified date of birth.
        /// </summary>
        [JsonPropertyName("dob")]
        public VerificationSessionVerifiedOutputsDob Dob { get; set; }

        /// <summary>
        /// The user's verified first name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The user's verified id number.
        /// </summary>
        [JsonPropertyName("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// The user's verified id number type.
        /// One of: <c>br_cpf</c>, <c>sg_nric</c>, or <c>us_ssn</c>.
        /// </summary>
        [JsonPropertyName("id_number_type")]
        public string IdNumberType { get; set; }

        /// <summary>
        /// The user's verified last name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
    }
}
