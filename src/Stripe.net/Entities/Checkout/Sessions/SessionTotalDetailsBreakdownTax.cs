// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionTotalDetailsBreakdownTax : StripeEntity<SessionTotalDetailsBreakdownTax>
    {
        /// <summary>
        /// Amount of tax applied for this rate.
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Tax rates can be applied to <a
        /// href="https://stripe.com/docs/billing/invoices/tax-rates">invoices</a>, <a
        /// href="https://stripe.com/docs/billing/subscriptions/taxes">subscriptions</a> and <a
        /// href="https://stripe.com/docs/payments/checkout/set-up-a-subscription#tax-rates">Checkout
        /// Sessions</a> to collect tax.
        ///
        /// Related guide: <a href="https://stripe.com/docs/billing/taxes/tax-rates">Tax Rates</a>.
        /// </summary>
        [JsonPropertyName("rate")]
        public TaxRate Rate { get; set; }
    }
}
