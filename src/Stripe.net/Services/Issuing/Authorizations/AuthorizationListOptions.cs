// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class AuthorizationListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("card")]
        public string Card { get; set; }

        [JsonPropertyName("cardholder")]
        public string Cardholder { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
