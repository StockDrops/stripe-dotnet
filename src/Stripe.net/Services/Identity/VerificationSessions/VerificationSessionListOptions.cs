// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Text.Json.Serialization;

    public class VerificationSessionListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
