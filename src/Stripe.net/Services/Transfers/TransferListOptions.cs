// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class TransferListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("destination")]
        public string Destination { get; set; }

        [JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
