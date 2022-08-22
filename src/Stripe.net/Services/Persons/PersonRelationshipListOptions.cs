namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PersonRelationshipListOptions : INestedOptions
    {
        [JsonPropertyName("director")]
        public bool? Director { get; set; }

        [JsonPropertyName("executive")]
        public bool? Executive { get; set; }

        [JsonPropertyName("owner")]
        public bool? Owner { get; set; }

        [JsonPropertyName("representative")]
        public bool? Representative { get; set; }
    }
}
