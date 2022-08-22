// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PersonRelationship : StripeEntity<PersonRelationship>
    {
        /// <summary>
        /// Whether the person is a director of the account's legal entity. Directors are typically
        /// members of the governing board of the company, or responsible for ensuring the company
        /// meets its regulatory obligations.
        /// </summary>
        [JsonPropertyName("director")]
        public bool? Director { get; set; }

        /// <summary>
        /// Whether the person has significant responsibility to control, manage, or direct the
        /// organization.
        /// </summary>
        [JsonPropertyName("executive")]
        public bool? Executive { get; set; }

        /// <summary>
        /// Whether the person is an owner of the account’s legal entity.
        /// </summary>
        [JsonPropertyName("owner")]
        public bool? Owner { get; set; }

        /// <summary>
        /// The percent owned by the person of the account's legal entity.
        /// </summary>
        [JsonPropertyName("percent_ownership")]
        public decimal? PercentOwnership { get; set; }

        /// <summary>
        /// Whether the person is authorized as the primary representative of the account. This is
        /// the person nominated by the business to provide information about themselves, and
        /// general information about the account. There can only be one representative at any given
        /// time. At the time the account is created, this person should be set to the person
        /// responsible for opening the account.
        /// </summary>
        [JsonPropertyName("representative")]
        public bool? Representative { get; set; }

        /// <summary>
        /// The person's title (e.g., CEO, Support Engineer).
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
