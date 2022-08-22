// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SubscriptionPaymentSettings : StripeEntity<SubscriptionPaymentSettings>
    {
        /// <summary>
        /// Payment-method-specific configuration to provide to invoices created by the
        /// subscription.
        /// </summary>
        [JsonPropertyName("payment_method_options")]
        public SubscriptionPaymentSettingsPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types to provide to every invoice created by the
        /// subscription. If not set, Stripe attempts to automatically determine the types to use by
        /// looking at the invoice’s default payment method, the subscription’s default payment
        /// method, the customer’s default payment method, and your <a
        /// href="https://dashboard.stripe.com/settings/billing/invoice">invoice template
        /// settings</a>.
        /// </summary>
        [JsonPropertyName("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Either <c>off</c>, or <c>on_subscription</c>. With <c>on_subscription</c> Stripe updates
        /// <c>subscription.default_payment_method</c> when a subscription payment succeeds.
        /// One of: <c>off</c>, or <c>on_subscription</c>.
        /// </summary>
        [JsonPropertyName("save_default_payment_method")]
        public string SaveDefaultPaymentMethod { get; set; }
    }
}
