// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Text.Json.Serialization;

    public class ConfigurationFeatures : StripeEntity<ConfigurationFeatures>
    {
        [JsonPropertyName("customer_update")]
        public ConfigurationFeaturesCustomerUpdate CustomerUpdate { get; set; }

        [JsonPropertyName("invoice_history")]
        public ConfigurationFeaturesInvoiceHistory InvoiceHistory { get; set; }

        [JsonPropertyName("payment_method_update")]
        public ConfigurationFeaturesPaymentMethodUpdate PaymentMethodUpdate { get; set; }

        [JsonPropertyName("subscription_cancel")]
        public ConfigurationFeaturesSubscriptionCancel SubscriptionCancel { get; set; }

        [JsonPropertyName("subscription_pause")]
        public ConfigurationFeaturesSubscriptionPause SubscriptionPause { get; set; }

        [JsonPropertyName("subscription_update")]
        public ConfigurationFeaturesSubscriptionUpdate SubscriptionUpdate { get; set; }
    }
}
