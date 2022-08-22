// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupAttemptListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("setup_intent")]
        public string SetupIntent { get; set; }
    }
}
