// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class QuoteFromQuoteOptions : INestedOptions
    {
        /// <summary>
        /// Whether this quote is a revision of the previous quote.
        /// </summary>
        [JsonPropertyName("is_revision")]
        public bool? IsRevision { get; set; }

        /// <summary>
        /// The <c>id</c> of the quote that will be cloned.
        /// </summary>
        [JsonPropertyName("quote")]
        public string Quote { get; set; }
    }
}
