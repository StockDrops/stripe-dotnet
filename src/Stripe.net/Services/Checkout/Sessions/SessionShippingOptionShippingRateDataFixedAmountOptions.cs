// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SessionShippingOptionShippingRateDataFixedAmountOptions : INestedOptions
    {
        /// <summary>
        /// A non-negative integer in cents representing how much to charge.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Shipping rates defined in each available currency option. Each key must be a
        /// three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a> and a <a href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonPropertyName("currency_options")]
        public Dictionary<string, SessionShippingOptionShippingRateDataFixedAmountCurrencyOptionsOptions> CurrencyOptions { get; set; }
    }
}
