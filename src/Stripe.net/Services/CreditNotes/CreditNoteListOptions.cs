// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CreditNoteListOptions : ListOptions
    {
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("invoice")]
        public string Invoice { get; set; }
    }
}
