// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionListOptions : ListOptions
    {
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("customer_details")]
        public SessionCustomerDetailsOptions CustomerDetails { get; set; }

        [JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        [JsonPropertyName("subscription")]
        public string Subscription { get; set; }
    }
}
