// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PersonListOptions : ListOptions
    {
        [JsonPropertyName("relationship")]
        public PersonRelationshipListOptions Relationship { get; set; }
    }
}
