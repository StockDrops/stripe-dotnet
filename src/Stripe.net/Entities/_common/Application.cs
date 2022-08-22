namespace Stripe
{
    using System.Text.Json.Serialization;

    public class Application : StripeEntity<Application>, IHasId, IHasObject
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
