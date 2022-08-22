namespace Stripe
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    [JsonConverter(typeof(StripeSearchResultConverterFactory))]
    public class StripeSearchResult<T> : StripeEntity<StripeSearchResult<T>>, IHasObject, IEnumerable<T>
    {
        /// <summary>
        /// A string describing the object type returned.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// A list containing the actual response elements, paginated by any request parameters.
        /// </summary>
        [JsonPropertyName("data")]
        public List<T> Data { get; set; }

        /// <summary>
        /// Whether or not there are more elements available after this set. If <c>false</c>,
        /// this set comprises the end of the list.
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// The URL for accessing this list.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// The URL for accessing the next page in search results.
        /// </summary>
        [JsonPropertyName("next_page")]
        public string NextPage { get; set; }

        /// <summary>
        /// The total count of entries in the search result, not just the current page.
        /// Only available when <see cref="BaseOptions.Expand"/> contains <c>"total_count"</c>.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }
    }
}
