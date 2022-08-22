// File generated from our OpenAPI spec
namespace Stripe.Sigma
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// If you have <a href="https://stripe.com/docs/sigma/scheduled-queries">scheduled a Sigma
    /// query</a>, you'll receive a <c>sigma.scheduled_query_run.created</c> webhook each time
    /// the query runs. The webhook contains a <c>ScheduledQueryRun</c> object, which you can
    /// use to retrieve the query results.
    /// </summary>
    public class ScheduledQueryRun : StripeEntity<ScheduledQueryRun>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// When the query was run, Sigma contained a snapshot of your Stripe data at this time.
        /// </summary>
        [JsonPropertyName("data_load_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DataLoadTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonPropertyName("error")]
        public ScheduledQueryRunError Error { get; set; }

        /// <summary>
        /// The file object representing the results of the query.
        /// </summary>
        [JsonPropertyName("file")]
        public File File { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Time at which the result expires and is no longer available for download.
        /// </summary>
        [JsonPropertyName("result_available_until")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ResultAvailableUntil { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// SQL for the query.
        /// </summary>
        [JsonPropertyName("sql")]
        public string Sql { get; set; }

        /// <summary>
        /// The query's execution status, which will be <c>completed</c> for successful runs, and
        /// <c>canceled</c>, <c>failed</c>, or <c>timed_out</c> otherwise.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Title of the query.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
