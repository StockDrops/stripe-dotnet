// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class TokenAccountCompanyVerificationOptions : INestedOptions
    {
        /// <summary>
        /// A document verifying the business.
        /// </summary>
        [JsonPropertyName("document")]
        public TokenAccountCompanyVerificationDocumentOptions Document { get; set; }
    }
}
