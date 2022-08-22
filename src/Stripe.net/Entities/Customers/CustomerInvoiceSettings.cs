// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class CustomerInvoiceSettings : StripeEntity<CustomerInvoiceSettings>
    {
        /// <summary>
        /// Default custom fields to be displayed on invoices for this customer.
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public List<CustomerInvoiceSettingsCustomField> CustomFields { get; set; }

        #region Expandable DefaultPaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of a payment method that's attached to the customer, to be used as the customer's
        /// default payment method for subscriptions and invoices.
        /// </summary>
        [JsonIgnore]
        public string DefaultPaymentMethodId
        {
            get => this.InternalDefaultPaymentMethod?.Id;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldId(value, this.InternalDefaultPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// ID of a payment method that's attached to the customer, to be used as the customer's
        /// default payment method for subscriptions and invoices.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentMethod DefaultPaymentMethod
        {
            get => this.InternalDefaultPaymentMethod?.ExpandedObject;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldObject(value, this.InternalDefaultPaymentMethod);
        }

        [JsonPropertyName("default_payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        [JsonInclude]
        public ExpandableField<PaymentMethod> InternalDefaultPaymentMethod { get; private set; }
        #endregion

        /// <summary>
        /// Default footer to be displayed on invoices for this customer.
        /// </summary>
        [JsonPropertyName("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Default options for invoice PDF rendering for this customer.
        /// </summary>
        [JsonPropertyName("rendering_options")]
        public CustomerInvoiceSettingsRenderingOptions RenderingOptions { get; set; }
    }
}
