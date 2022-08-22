// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class TransactionListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("card")]
        public string Card { get; set; }

        [JsonPropertyName("cardholder")]
        public string Cardholder { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
