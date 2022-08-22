// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Text.Json.Serialization;

    public class EarlyFraudWarningListOptions : ListOptions
    {
        [JsonPropertyName("charge")]
        public string Charge { get; set; }

        [JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
