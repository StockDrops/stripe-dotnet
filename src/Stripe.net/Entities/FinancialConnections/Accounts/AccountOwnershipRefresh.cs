// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class AccountOwnershipRefresh : StripeEntity<AccountOwnershipRefresh>
    {
        /// <summary>
        /// The time at which the last refresh attempt was initiated. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonPropertyName("last_attempted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime LastAttemptedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The status of the last refresh attempt.
        /// One of: <c>failed</c>, <c>pending</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
