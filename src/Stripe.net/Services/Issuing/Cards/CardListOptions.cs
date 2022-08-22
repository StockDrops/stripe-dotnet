// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("cardholder")]
        public string Cardholder { get; set; }

        [JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
