// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CustomerInvoiceSettingsRenderingOptions : StripeEntity<CustomerInvoiceSettingsRenderingOptions>
    {
        /// <summary>
        /// How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.
        /// </summary>
        [JsonPropertyName("amount_tax_display")]
        public string AmountTaxDisplay { get; set; }
    }
}
