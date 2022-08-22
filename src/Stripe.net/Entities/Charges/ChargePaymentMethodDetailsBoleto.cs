// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsBoleto : StripeEntity<ChargePaymentMethodDetailsBoleto>
    {
        /// <summary>
        /// The tax ID of the customer (CPF for individuals consumers or CNPJ for businesses
        /// consumers).
        /// </summary>
        [JsonPropertyName("tax_id")]
        public string TaxId { get; set; }
    }
}
