namespace Stripe
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class StripeList<T> : StripeEntity<StripeList<T>>, IHasObject, IEnumerable<T>, IBaseStripeList
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

        public IEnumerator<T> GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }

        /// <summary>
        /// Reverse the order of the items in Data to support backward iteration
        /// in autopagination with EndingBefore.
        /// </summary>
        public void Reverse()
        {
            this.Data.Reverse();
        }
    }
}
