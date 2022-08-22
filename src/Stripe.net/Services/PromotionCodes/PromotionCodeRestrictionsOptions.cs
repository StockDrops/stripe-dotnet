// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PromotionCodeRestrictionsOptions : INestedOptions
    {
        /// <summary>
        /// Promotion codes defined in each available currency option. Each key must be a
        /// three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a> and a <a href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonPropertyName("currency_options")]
        public Dictionary<string, PromotionCodeRestrictionsCurrencyOptionsOptions> CurrencyOptions { get; set; }

        /// <summary>
        /// A Boolean indicating if the Promotion Code should only be redeemed for Customers without
        /// any successful payments or invoices.
        /// </summary>
        [JsonPropertyName("first_time_transaction")]
        public bool? FirstTimeTransaction { get; set; }

        /// <summary>
        /// Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase
        /// must be $100 or more to work).
        /// </summary>
        [JsonPropertyName("minimum_amount")]
        public long? MinimumAmount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code</a> for
        /// minimum_amount.
        /// </summary>
        [JsonPropertyName("minimum_amount_currency")]
        public string MinimumAmountCurrency { get; set; }
    }
}
