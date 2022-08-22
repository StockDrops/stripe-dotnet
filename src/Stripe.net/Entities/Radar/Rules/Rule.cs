namespace Stripe.Radar
{
    using System.Text.Json.Serialization;

    public class Rule : StripeEntity<Rule>, IHasId
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("deleted")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        [JsonPropertyName("predicate")]
        public string Predicate { get; set; }
    }
}
