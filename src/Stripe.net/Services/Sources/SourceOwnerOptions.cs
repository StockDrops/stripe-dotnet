// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceOwnerOptions : INestedOptions
    {
        /// <summary>
        /// Owner's address.
        /// </summary>
        [JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

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
        /// Owner's phone number.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
