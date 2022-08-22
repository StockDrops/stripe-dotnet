// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsOptions : INestedOptions
    {
        /// <summary>
        /// Setting to true enables installments for this invoice. Setting to false will prevent any
        /// selected plan from applying to a payment.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The selected installment plan to use for this invoice.
        /// </summary>
        [JsonPropertyName("plan")]
        public InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsPlanOptions Plan { get; set; }
    }
}
