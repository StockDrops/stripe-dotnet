// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionPaymentMethodOptionsCardInstallmentsOptions : INestedOptions
    {
        /// <summary>
        /// Setting to true enables installments for this PaymentIntent. This will cause the
        /// response to contain a list of available installment plans. Setting to false will prevent
        /// any selected plan from applying to a charge.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The selected installment plan to use for this payment attempt. This parameter can only
        /// be provided during confirmation.
        /// </summary>
        [JsonPropertyName("plan")]
        public SessionPaymentMethodOptionsCardInstallmentsPlanOptions Plan { get; set; }
    }
}
