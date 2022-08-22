// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ValueListUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The name of the value list for use in rules.
        /// </summary>
        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The human-readable name of the value list.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
