// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodOptionsUsBankAccountNetworksOptions : INestedOptions
    {
        /// <summary>
        /// Triggers validations to run across the selected networks.
        /// </summary>
        [JsonPropertyName("requested")]
        public List<string> Requested { get; set; }
    }
}
