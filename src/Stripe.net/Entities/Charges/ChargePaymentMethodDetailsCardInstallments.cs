// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsCardInstallments : StripeEntity<ChargePaymentMethodDetailsCardInstallments>
    {
        /// <summary>
        /// Installment plan selected for the payment.
        /// </summary>
        [JsonPropertyName("plan")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlan Plan { get; set; }
    }
}
