// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardholderIndividual : StripeEntity<CardholderIndividual>
    {
        /// <summary>
        /// The date of birth of this cardholder.
        /// </summary>
        [JsonPropertyName("dob")]
        public CardholderIndividualDob Dob { get; set; }

        /// <summary>
        /// The first name of this cardholder.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of this cardholder.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Government-issued ID document for this cardholder.
        /// </summary>
        [JsonPropertyName("verification")]
        public CardholderIndividualVerification Verification { get; set; }
    }
}
