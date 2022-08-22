// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodOptionsBlik : StripeEntity<SetupIntentPaymentMethodOptionsBlik>
    {
        [JsonPropertyName("mandate_options")]
        public SetupIntentPaymentMethodOptionsBlikMandateOptions MandateOptions { get; set; }
    }
}
