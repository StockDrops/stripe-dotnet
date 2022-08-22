// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Text.Json.Serialization;

    public class ValueListItemListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("value_list")]
        public string ValueList { get; set; }
    }
}
