// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Text.Json.Serialization;

    public class ValueListListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        [JsonPropertyName("contains")]
        public string Contains { get; set; }
    }
}
