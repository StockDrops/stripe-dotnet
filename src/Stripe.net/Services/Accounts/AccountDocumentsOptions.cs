// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// One or more documents that support the <a
        /// href="https://support.stripe.com/questions/bank-account-ownership-verification">Bank
        /// account ownership verification</a> requirement. Must be a document associated with the
        /// account’s primary active bank account that displays the last 4 digits of the account
        /// number, either a statement or a voided check.
        /// </summary>
        [JsonPropertyName("bank_account_ownership_verification")]
        public AccountDocumentsBankAccountOwnershipVerificationOptions BankAccountOwnershipVerification { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company's license to operate.
        /// </summary>
        [JsonPropertyName("company_license")]
        public AccountDocumentsCompanyLicenseOptions CompanyLicense { get; set; }

        /// <summary>
        /// One or more documents showing the company's Memorandum of Association.
        /// </summary>
        [JsonPropertyName("company_memorandum_of_association")]
        public AccountDocumentsCompanyMemorandumOfAssociationOptions CompanyMemorandumOfAssociation { get; set; }

        /// <summary>
        /// (Certain countries only) One or more documents showing the ministerial decree legalizing
        /// the company's establishment.
        /// </summary>
        [JsonPropertyName("company_ministerial_decree")]
        public AccountDocumentsCompanyMinisterialDecreeOptions CompanyMinisterialDecree { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company's registration with the
        /// appropriate local authorities.
        /// </summary>
        [JsonPropertyName("company_registration_verification")]
        public AccountDocumentsCompanyRegistrationVerificationOptions CompanyRegistrationVerification { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company's tax ID.
        /// </summary>
        [JsonPropertyName("company_tax_id_verification")]
        public AccountDocumentsCompanyTaxIdVerificationOptions CompanyTaxIdVerification { get; set; }

        /// <summary>
        /// One or more documents showing the company’s proof of registration with the national
        /// business registry.
        /// </summary>
        [JsonPropertyName("proof_of_registration")]
        public AccountDocumentsProofOfRegistrationOptions ProofOfRegistration { get; set; }
    }
}
