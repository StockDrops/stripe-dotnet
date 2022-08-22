// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class CustomerInvoiceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Default custom fields to be displayed on invoices for this customer. When updating, pass
        /// an empty string to remove previously-defined fields.
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public List<CustomerInvoiceSettingsCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// ID of a payment method that's attached to the customer, to be used as the customer's
        /// default payment method for subscriptions and invoices.
        /// </summary>
        [JsonPropertyName("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Default footer to be displayed on invoices for this customer.
        /// </summary>
        [JsonPropertyName("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Default options for invoice PDF rendering for this customer.
        /// </summary>
        [JsonPropertyName("rendering_options")]
        public CustomerInvoiceSettingsRenderingOptionsOptions RenderingOptions { get; set; }
    }
}
