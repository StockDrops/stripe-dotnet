// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Text.Json.Serialization;

    public class VerificationSessionOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Options that apply to the <a
        /// href="https://stripe.com/docs/identity/verification-checks?type=document">document
        /// check</a>.
        /// </summary>
        [JsonPropertyName("document")]
        public VerificationSessionOptionsDocumentOptions Document { get; set; }
    }
}
