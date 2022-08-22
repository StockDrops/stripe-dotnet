// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentPaymentMethodDataRadarOptionsOptions : INestedOptions
    {
        /// <summary>
        /// A <a href="https://stripe.com/docs/radar/radar-session">Radar Session</a> is a snapshot
        /// of the browser metadata and device details that help Radar make more accurate
        /// predictions on your payments.
        /// </summary>
        [JsonPropertyName("session")]
        public string Session { get; set; }
    }
}
