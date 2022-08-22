// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceOwner : StripeEntity<SourceOwner>
    {
        /// <summary>
        /// Owner's address.
        /// </summary>
        [JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Owner's email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Owner's full name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Owner's phone number (including extension).
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Verified owner's address. Verified values are verified or provided by the payment method
        /// directly (and if supported) at the time of authorization or settlement. They cannot be
        /// set or mutated.
        /// </summary>
        [JsonPropertyName("verified_address")]
        public Address VerifiedAddress { get; set; }

        /// <summary>
        /// Verified owner's email address. Verified values are verified or provided by the payment
        /// method directly (and if supported) at the time of authorization or settlement. They
        /// cannot be set or mutated.
        /// </summary>
        [JsonPropertyName("verified_email")]
        public string VerifiedEmail { get; set; }

        /// <summary>
        /// Verified owner's full name. Verified values are verified or provided by the payment
        /// method directly (and if supported) at the time of authorization or settlement. They
        /// cannot be set or mutated.
        /// </summary>
        [JsonPropertyName("verified_name")]
        public string VerifiedName { get; set; }

        /// <summary>
        /// Verified owner's phone number (including extension). Verified values are verified or
        /// provided by the payment method directly (and if supported) at the time of authorization
        /// or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonPropertyName("verified_phone")]
        public string VerifiedPhone { get; set; }
    }
}
