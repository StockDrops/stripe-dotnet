// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountCompanyOptions : INestedOptions
    {
        /// <summary>
        /// The company's primary address.
        /// </summary>
        [JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The Kana variation of the company's primary address (Japan only).
        /// </summary>
        [JsonPropertyName("address_kana")]
        public AddressJapanOptions AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company's primary address (Japan only).
        /// </summary>
        [JsonPropertyName("address_kanji")]
        public AddressJapanOptions AddressKanji { get; set; }

        /// <summary>
        /// Whether the company's directors have been provided. Set this Boolean to <c>true</c>
        /// after creating all the company's directors with <a
        /// href="https://stripe.com/docs/api/persons">the Persons API</a> for accounts with a
        /// <c>relationship.director</c> requirement. This value is not automatically set to
        /// <c>true</c> after creating directors, so it needs to be updated to indicate all
        /// directors have been provided.
        /// </summary>
        [JsonPropertyName("directors_provided")]
        public bool? DirectorsProvided { get; set; }

        /// <summary>
        /// Whether the company's executives have been provided. Set this Boolean to <c>true</c>
        /// after creating all the company's executives with <a
        /// href="https://stripe.com/docs/api/persons">the Persons API</a> for accounts with a
        /// <c>relationship.executive</c> requirement.
        /// </summary>
        [JsonPropertyName("executives_provided")]
        public bool? ExecutivesProvided { get; set; }

        /// <summary>
        /// The company's legal name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The Kana variation of the company's legal name (Japan only).
        /// </summary>
        [JsonPropertyName("name_kana")]
        public string NameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company's legal name (Japan only).
        /// </summary>
        [JsonPropertyName("name_kanji")]
        public string NameKanji { get; set; }

        /// <summary>
        /// Whether the company's owners have been provided. Set this Boolean to <c>true</c> after
        /// creating all the company's owners with <a href="https://stripe.com/docs/api/persons">the
        /// Persons API</a> for accounts with a <c>relationship.owner</c> requirement.
        /// </summary>
        [JsonPropertyName("owners_provided")]
        public bool? OwnersProvided { get; set; }

        /// <summary>
        /// This hash is used to attest that the beneficial owner information provided to Stripe is
        /// both current and correct.
        /// </summary>
        [JsonPropertyName("ownership_declaration")]
        public AccountCompanyOwnershipDeclarationOptions OwnershipDeclaration { get; set; }

        /// <summary>
        /// The company's phone number (used for verification).
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The identification number given to a company when it is registered or incorporated, if
        /// distinct from the identification number used for filing taxes. (Examples are the CIN for
        /// companies and LLP IN for partnerships in India, and the Company Registration Number in
        /// Hong Kong).
        /// </summary>
        [JsonPropertyName("registration_number")]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// The category identifying the legal structure of the company or legal entity. See <a
        /// href="https://stripe.com/docs/connect/identity-verification#business-structure">Business
        /// structure</a> for more details.
        /// </summary>
        [JsonPropertyName("structure")]
        public string Structure { get; set; }

        /// <summary>
        /// The business ID number of the company, as appropriate for the company’s country.
        /// (Examples are an Employer ID Number in the U.S., a Business Number in Canada, or a
        /// Company Number in the UK.).
        /// </summary>
        [JsonPropertyName("tax_id")]
        public string TaxId { get; set; }

        /// <summary>
        /// The jurisdiction in which the <c>tax_id</c> is registered (Germany-based companies
        /// only).
        /// </summary>
        [JsonPropertyName("tax_id_registrar")]
        public string TaxIdRegistrar { get; set; }

        /// <summary>
        /// The VAT number of the company.
        /// </summary>
        [JsonPropertyName("vat_id")]
        public string VatId { get; set; }

        /// <summary>
        /// Information on the verification state of the company.
        /// </summary>
        [JsonPropertyName("verification")]
        public AccountCompanyVerificationOptions Verification { get; set; }
    }
}
