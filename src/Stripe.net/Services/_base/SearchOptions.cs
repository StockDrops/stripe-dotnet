namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SearchOptions : BaseOptions
    {
        /// <summary>
        /// A limit on the number of objects to be returned, between 1 and 100.
        /// </summary>
        [JsonPropertyName("limit")]
        public long? Limit { get; set; }

        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("query")]
        public string Query { get; set; }
    }
}
