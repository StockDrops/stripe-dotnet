// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PaymentIntentPaymentMethodOptionsCardInstallments : StripeEntity<PaymentIntentPaymentMethodOptionsCardInstallments>
    {
        /// <summary>
        /// Installment plans that may be selected for this PaymentIntent.
        /// </summary>
        [JsonPropertyName("available_plans")]
        public List<PaymentIntentPaymentMethodOptionsCardInstallmentsPlan> AvailablePlans { get; set; }

        /// <summary>
        /// Whether Installments are enabled for this PaymentIntent.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Installment plan selected for this PaymentIntent.
        /// </summary>
        [JsonPropertyName("plan")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlan Plan { get; set; }
    }
}
