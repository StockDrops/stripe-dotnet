// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Text.Json.Serialization;

    public class ReceivedCreditCreateOptions : BaseOptions
    {
        /// <summary>
        /// Amount (in cents) to be transferred.
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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The FinancialAccount to send funds to.
        /// </summary>
        [JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Initiating payment method details for the object.
        /// </summary>
        [JsonPropertyName("initiating_payment_method_details")]
        public ReceivedCreditInitiatingPaymentMethodDetailsOptions InitiatingPaymentMethodDetails { get; set; }

        /// <summary>
        /// The rails used for the object.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
