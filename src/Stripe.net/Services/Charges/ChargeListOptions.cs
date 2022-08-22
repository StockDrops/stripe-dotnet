// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargeListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        [JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
