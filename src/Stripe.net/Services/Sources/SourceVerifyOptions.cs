// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SourceVerifyOptions : BaseOptions
    {
        /// <summary>
        /// The values needed to verify the source.
        /// </summary>
        [JsonPropertyName("values")]
        public List<string> Values { get; set; }
    }
}
