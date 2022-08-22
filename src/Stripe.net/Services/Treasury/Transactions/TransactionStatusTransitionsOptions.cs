// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class TransactionStatusTransitionsOptions : INestedOptions
    {
        /// <summary>
        /// Returns Transactions with <c>posted_at</c> within the specified range.
        /// </summary>
        [JsonPropertyName("posted_at")]
        [JsonConverter(typeof(AnyOfConverterFactory))]
        public AnyOf<DateTime?, DateRangeOptions> PostedAt { get; set; }
    }
}
