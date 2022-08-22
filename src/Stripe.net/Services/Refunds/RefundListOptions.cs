// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class RefundListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("charge")]
        public string Charge { get; set; }

        [JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
