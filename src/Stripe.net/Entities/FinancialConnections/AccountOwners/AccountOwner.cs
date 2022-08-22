// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class AccountOwner : StripeEntity<AccountOwner>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The email address of the owner.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The full name of the owner.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The ownership object that this owner belongs to.
        /// </summary>
        [JsonPropertyName("ownership")]
        public string Ownership { get; set; }

        /// <summary>
        /// The raw phone number of the owner.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The raw physical address of the owner.
        /// </summary>
        [JsonPropertyName("raw_address")]
        public string RawAddress { get; set; }

        /// <summary>
        /// The timestamp of the refresh that updated this owner.
        /// </summary>
        [JsonPropertyName("refreshed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? RefreshedAt { get; set; }
    }
}
