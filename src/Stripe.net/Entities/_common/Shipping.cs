namespace Stripe
{
    using System.Text.Json.Serialization;

    public class Shipping : StripeEntity<Shipping>
    {
        [JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
