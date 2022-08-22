// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentPaymentMethodOptionsBlikOptions : INestedOptions
    {
        /// <summary>
        /// The 6-digit BLIK code that a customer has generated using their banking application. Can
        /// only be set on confirmation.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
