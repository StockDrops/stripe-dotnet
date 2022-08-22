// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardholderIndividualOptions : INestedOptions
    {
        /// <summary>
        /// The date of birth of this cardholder.
        /// </summary>
        [JsonPropertyName("dob")]
        public CardholderIndividualDobOptions Dob { get; set; }

        /// <summary>
        /// The first name of this cardholder. This field cannot contain any special characters or
        /// numbers.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of this cardholder. This field cannot contain any special characters or
        /// numbers.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Government-issued ID document for this cardholder.
        /// </summary>
        [JsonPropertyName("verification")]
        public CardholderIndividualVerificationOptions Verification { get; set; }
    }
}
