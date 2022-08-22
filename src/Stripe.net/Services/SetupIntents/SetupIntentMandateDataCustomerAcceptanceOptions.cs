// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SetupIntentMandateDataCustomerAcceptanceOptions : INestedOptions
    {
        /// <summary>
        /// The time at which the customer accepted the Mandate.
        /// </summary>
        [JsonPropertyName("accepted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// If this is a Mandate accepted offline, this hash contains details about the offline
        /// acceptance.
        /// </summary>
        [JsonPropertyName("offline")]
        public SetupIntentMandateDataCustomerAcceptanceOfflineOptions Offline { get; set; }

        /// <summary>
        /// If this is a Mandate accepted online, this hash contains details about the online
        /// acceptance.
        /// </summary>
        [JsonPropertyName("online")]
        public SetupIntentMandateDataCustomerAcceptanceOnlineOptions Online { get; set; }

        /// <summary>
        /// The type of customer acceptance information included with the Mandate. One of
        /// <c>online</c> or <c>offline</c>.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
