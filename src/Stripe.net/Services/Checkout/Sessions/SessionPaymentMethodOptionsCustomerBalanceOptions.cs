// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionPaymentMethodOptionsCustomerBalanceOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for the bank transfer funding type, if the <c>funding_type</c> is set to
        /// <c>bank_transfer</c>.
        /// </summary>
        [JsonPropertyName("bank_transfer")]
        public SessionPaymentMethodOptionsCustomerBalanceBankTransferOptions BankTransfer { get; set; }

        /// <summary>
        /// The funding method type to be used when there are not enough funds in the customer
        /// balance. Permitted values include: <c>bank_transfer</c>.
        /// </summary>
        [JsonPropertyName("funding_type")]
        public string FundingType { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent's payment
        /// method.
        ///
        /// Providing this parameter will <a
        /// href="https://stripe.com/docs/payments/save-during-payment">attach the payment
        /// method</a> to the PaymentIntent's Customer, if present, after the PaymentIntent is
        /// confirmed and any required actions from the user are complete. If no Customer was
        /// provided, the payment method can still be <a
        /// href="https://stripe.com/docs/api/payment_methods/attach">attached</a> to a Customer
        /// after the transaction completes.
        ///
        /// When processing card payments, Stripe also uses <c>setup_future_usage</c> to dynamically
        /// optimize your payment flow and comply with regional legislation and network rules, such
        /// as <a href="https://stripe.com/docs/strong-customer-authentication">SCA</a>.
        /// </summary>
        [JsonPropertyName("setup_future_usage")]
        public string SetupFutureUsage { get; set; }
    }
}