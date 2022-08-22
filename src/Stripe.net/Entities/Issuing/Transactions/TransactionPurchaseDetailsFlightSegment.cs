// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class TransactionPurchaseDetailsFlightSegment : StripeEntity<TransactionPurchaseDetailsFlightSegment>
    {
        /// <summary>
        /// The three-letter IATA airport code of the flight's destination.
        /// </summary>
        [JsonPropertyName("arrival_airport_code")]
        public string ArrivalAirportCode { get; set; }

        /// <summary>
        /// The airline carrier code.
        /// </summary>
        [JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// The three-letter IATA airport code that the flight departed from.
        /// </summary>
        [JsonPropertyName("departure_airport_code")]
        public string DepartureAirportCode { get; set; }

        /// <summary>
        /// The flight number.
        /// </summary>
        [JsonPropertyName("flight_number")]
        public string FlightNumber { get; set; }

        /// <summary>
        /// The flight's service class.
        /// </summary>
        [JsonPropertyName("service_class")]
        public string ServiceClass { get; set; }

        /// <summary>
        /// Whether a stopover is allowed on this flight.
        /// </summary>
        [JsonPropertyName("stopover_allowed")]
        public bool? StopoverAllowed { get; set; }
    }
}
