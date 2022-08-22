// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodOptionsSepaDebit : StripeEntity<SetupIntentPaymentMethodOptionsSepaDebit>
    {
        [JsonPropertyName("mandate_options")]
        public SetupIntentPaymentMethodOptionsSepaDebitMandateOptions MandateOptions { get; set; }
    }
}
