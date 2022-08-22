// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class TransactionPurchaseDetailsFlight : StripeEntity<TransactionPurchaseDetailsFlight>
    {
        /// <summary>
        /// The time that the flight departed.
        /// </summary>
        [JsonPropertyName("departure_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DepartureAt { get; set; }

        /// <summary>
        /// The name of the passenger.
        /// </summary>
        [JsonPropertyName("passenger_name")]
        public string PassengerName { get; set; }

        /// <summary>
        /// Whether the ticket is refundable.
        /// </summary>
        [JsonPropertyName("refundable")]
        public bool? Refundable { get; set; }

        /// <summary>
        /// The legs of the trip.
        /// </summary>
        [JsonPropertyName("segments")]
        public List<TransactionPurchaseDetailsFlightSegment> Segments { get; set; }

        /// <summary>
        /// The travel agency that issued the ticket.
        /// </summary>
        [JsonPropertyName("travel_agency")]
        public string TravelAgency { get; set; }
    }
}
