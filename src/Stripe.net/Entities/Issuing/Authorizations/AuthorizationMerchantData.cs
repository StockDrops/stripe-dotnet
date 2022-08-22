// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class AuthorizationMerchantData : StripeEntity<AuthorizationMerchantData>
    {
        /// <summary>
        /// A categorization of the seller's type of business. See our <a
        /// href="https://stripe.com/docs/issuing/merchant-categories">merchant categories guide</a>
        /// for a list of possible values.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// The merchant category code for the seller’s business.
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// City where the seller is located.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Country where the seller is located.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Name of the seller.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Identifier assigned to the seller by the card brand.
        /// </summary>
        [JsonPropertyName("network_id")]
        public string NetworkId { get; set; }

        /// <summary>
        /// Postal code where the seller is located.
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// State where the seller is located.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
