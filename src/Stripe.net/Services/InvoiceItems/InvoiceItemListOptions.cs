// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class InvoiceItemListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        [JsonPropertyName("pending")]
        public bool? Pending { get; set; }
    }
}
