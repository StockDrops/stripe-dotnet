// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class InvoicePaymentSettingsPaymentMethodOptionsCardInstallments : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsCardInstallments>
    {
        /// <summary>
        /// Whether Installments are enabled for this Invoice.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
