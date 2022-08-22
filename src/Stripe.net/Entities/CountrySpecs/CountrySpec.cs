// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Stripe needs to collect certain pieces of information about each account created. These
    /// requirements can differ depending on the account's country. The Country Specs API makes
    /// these rules available to your integration.
    ///
    /// You can also view the information from this API call as <a
    /// href="https://stripe.com/docs/connect/required-verification-information">an online
    /// guide</a>.
    /// </summary>
    public class CountrySpec : StripeEntity<CountrySpec>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object. Represented as the ISO country code for this country.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The default currency for this country. This applies to both payment methods and bank
        /// accounts.
        /// </summary>
        [JsonPropertyName("default_currency")]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Currencies that can be accepted in the specific country (for transfers).
        /// </summary>
        [JsonPropertyName("supported_bank_account_currencies")]
        public Dictionary<string, List<string>> SupportedBankAccountCurrencies { get; set; }

        /// <summary>
        /// Currencies that can be accepted in the specified country (for payments).
        /// </summary>
        [JsonPropertyName("supported_payment_currencies")]
        public List<string> SupportedPaymentCurrencies { get; set; }

        /// <summary>
        /// Payment methods available in the specified country. You may need to enable some payment
        /// methods (e.g., <a href="https://stripe.com/docs/ach">ACH</a>) on your account before
        /// they appear in this list. The <c>stripe</c> payment method refers to <a
        /// href="https://stripe.com/docs/connect/destination-charges">charging through your
        /// platform</a>.
        /// </summary>
        [JsonPropertyName("supported_payment_methods")]
        public List<string> SupportedPaymentMethods { get; set; }

        /// <summary>
        /// Countries that can accept transfers from the specified country.
        /// </summary>
        [JsonPropertyName("supported_transfer_countries")]
        public List<string> SupportedTransferCountries { get; set; }

        [JsonPropertyName("verification_fields")]
        public Dictionary<string, Dictionary<string, List<string>>> VerificationFields { get; set; }
    }
}
