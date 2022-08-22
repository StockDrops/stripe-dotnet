// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ApplicationFeeListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("charge")]
        public string Charge { get; set; }
    }
}
