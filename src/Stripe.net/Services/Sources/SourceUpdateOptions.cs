// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SourceUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount associated with the source.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("card")]
        public SourceCardOptions Card { get; set; }

        /// <summary>
        /// Information about a mandate possibility attached to a source object (generally for bank
        /// debits) as well as its acceptance status.
        /// </summary>
        [JsonPropertyName("mandate")]
        public SourceMandateOptions Mandate { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Information about the owner of the payment instrument that may be used or required by
        /// particular source types.
        /// </summary>
        [JsonPropertyName("owner")]
        public SourceOwnerOptions Owner { get; set; }

        /// <summary>
        /// Information about the items and shipping associated with the source. Required for
        /// transactional credit (for example Klarna) sources before you can charge it.
        /// </summary>
        [JsonPropertyName("source_order")]
        public SourceSourceOrderOptions SourceOrder { get; set; }
    }
}
