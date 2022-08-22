// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentMandateDataOptions : INestedOptions
    {
        /// <summary>
        /// This hash contains details about the customer acceptance of the Mandate.
        /// </summary>
        [JsonPropertyName("customer_acceptance")]
        public SetupIntentMandateDataCustomerAcceptanceOptions CustomerAcceptance { get; set; }
    }
}
