// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SourceMandateAcceptanceOptions : INestedOptions
    {
        /// <summary>
        /// The Unix timestamp (in seconds) when the mandate was accepted or refused by the
        /// customer.
        /// </summary>
        [JsonPropertyName("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the mandate was accepted or refused by the customer.
        /// </summary>
        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The parameters required to store a mandate accepted offline. Should only be set if
        /// <c>mandate[type]</c> is <c>offline</c>.
        /// </summary>
        [JsonPropertyName("offline")]
        public SourceMandateAcceptanceOfflineOptions Offline { get; set; }

        /// <summary>
        /// The parameters required to store a mandate accepted online. Should only be set if
        /// <c>mandate[type]</c> is <c>online</c>.
        /// </summary>
        [JsonPropertyName("online")]
        public SourceMandateAcceptanceOnlineOptions Online { get; set; }

        /// <summary>
        /// The status of the mandate acceptance. Either <c>accepted</c> (the mandate was accepted)
        /// or <c>refused</c> (the mandate was refused).
        /// One of: <c>accepted</c>, <c>pending</c>, <c>refused</c>, or <c>revoked</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of acceptance information included with the mandate. Either <c>online</c> or
        /// <c>offline</c>.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The user agent of the browser from which the mandate was accepted or refused by the
        /// customer.
        /// </summary>
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
