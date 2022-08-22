// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("attach_to_self")]
        public bool? AttachToSelf { get; set; }

        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }
    }
}
