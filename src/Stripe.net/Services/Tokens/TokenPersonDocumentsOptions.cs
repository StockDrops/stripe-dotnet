// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class TokenPersonDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// One or more documents that demonstrate proof that this person is authorized to represent
        /// the company.
        /// </summary>
        [JsonPropertyName("company_authorization")]
        public TokenPersonDocumentsCompanyAuthorizationOptions CompanyAuthorization { get; set; }

        /// <summary>
        /// One or more documents showing the person's passport page with photo and personal data.
        /// </summary>
        [JsonPropertyName("passport")]
        public TokenPersonDocumentsPassportOptions Passport { get; set; }

        /// <summary>
        /// One or more documents showing the person's visa required for living in the country where
        /// they are residing.
        /// </summary>
        [JsonPropertyName("visa")]
        public TokenPersonDocumentsVisaOptions Visa { get; set; }
    }
}
