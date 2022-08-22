// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodOptionsSepaDebitOptions : INestedOptions
    {
        /// <summary>
        /// Additional fields for Mandate creation.
        /// </summary>
        [JsonPropertyName("mandate_options")]
        public SetupIntentPaymentMethodOptionsSepaDebitMandateOptionsOptions MandateOptions { get; set; }
    }
}
