// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Text.Json.Serialization;

    public class ValueListItemCreateOptions : BaseOptions
    {
        /// <summary>
        /// The value of the item (whose type must match the type of the parent value list).
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// The identifier of the value list which the created item will be added to.
        /// </summary>
        [JsonPropertyName("value_list")]
        public string ValueList { get; set; }
    }
}
