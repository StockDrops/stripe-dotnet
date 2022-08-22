// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountCompanyVerificationOptions : INestedOptions
    {
        /// <summary>
        /// A document verifying the business.
        /// </summary>
        [JsonPropertyName("document")]
        public AccountCompanyVerificationDocumentOptions Document { get; set; }
    }
}
