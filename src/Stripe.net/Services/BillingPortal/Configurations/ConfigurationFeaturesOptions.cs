// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Text.Json.Serialization;

    public class ConfigurationFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Information about updating the customer details in the portal.
        /// </summary>
        [JsonPropertyName("customer_update")]
        public ConfigurationFeaturesCustomerUpdateOptions CustomerUpdate { get; set; }

        /// <summary>
        /// Information about showing the billing history in the portal.
        /// </summary>
        [JsonPropertyName("invoice_history")]
        public ConfigurationFeaturesInvoiceHistoryOptions InvoiceHistory { get; set; }

        /// <summary>
        /// Information about updating payment methods in the portal.
        /// </summary>
        [JsonPropertyName("payment_method_update")]
        public ConfigurationFeaturesPaymentMethodUpdateOptions PaymentMethodUpdate { get; set; }

        /// <summary>
        /// Information about canceling subscriptions in the portal.
        /// </summary>
        [JsonPropertyName("subscription_cancel")]
        public ConfigurationFeaturesSubscriptionCancelOptions SubscriptionCancel { get; set; }

        /// <summary>
        /// Information about pausing subscriptions in the portal.
        /// </summary>
        [JsonPropertyName("subscription_pause")]
        public ConfigurationFeaturesSubscriptionPauseOptions SubscriptionPause { get; set; }

        /// <summary>
        /// Information about updating subscriptions in the portal.
        /// </summary>
        [JsonPropertyName("subscription_update")]
        public ConfigurationFeaturesSubscriptionUpdateOptions SubscriptionUpdate { get; set; }
    }
}
