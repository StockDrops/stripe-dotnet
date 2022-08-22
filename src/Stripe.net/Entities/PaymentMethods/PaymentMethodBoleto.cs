// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentMethodBoleto : StripeEntity<PaymentMethodBoleto>
    {
        /// <summary>
        /// Uniquely identifies the customer tax id (CNPJ or CPF).
        /// </summary>
        [JsonPropertyName("tax_id")]
        public string TaxId { get; set; }
    }
}
