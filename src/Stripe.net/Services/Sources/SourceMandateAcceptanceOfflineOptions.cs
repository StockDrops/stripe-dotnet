// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceMandateAcceptanceOfflineOptions : INestedOptions
    {
        /// <summary>
        /// An email to contact you with if a copy of the mandate is requested, required if
        /// <c>type</c> is <c>offline</c>.
        /// </summary>
        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }
    }
}
