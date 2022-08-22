// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class ReceivedCreditInitiatingPaymentMethodDetails : StripeEntity<ReceivedCreditInitiatingPaymentMethodDetails>
    {
        /// <summary>
        /// Set when <c>type</c> is <c>balance</c>.
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        [JsonPropertyName("billing_details")]
        public ReceivedCreditInitiatingPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonPropertyName("financial_account")]
        public ReceivedCreditInitiatingPaymentMethodDetailsFinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// Set when <c>type</c> is <c>issuing_card</c>. This is an <a
        /// href="https://stripe.com/docs/api#issuing_cards">Issuing Card</a> ID.
        /// </summary>
        [JsonPropertyName("issuing_card")]
        public string IssuingCard { get; set; }

        /// <summary>
        /// Polymorphic type matching the originating money movement's source. This can be an
        /// external account, a Stripe balance, or a FinancialAccount.
        /// One of: <c>balance</c>, <c>financial_account</c>, <c>issuing_card</c>, <c>stripe</c>, or
        /// <c>us_bank_account</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("us_bank_account")]
        public ReceivedCreditInitiatingPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
