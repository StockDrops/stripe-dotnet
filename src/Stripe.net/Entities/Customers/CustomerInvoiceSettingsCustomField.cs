// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CustomerInvoiceSettingsCustomField : StripeEntity<CustomerInvoiceSettingsCustomField>
    {
        /// <summary>
        /// The name of the custom field.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the custom field.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
