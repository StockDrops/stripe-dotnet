// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodDataKlarnaOptions : INestedOptions
    {
        /// <summary>
        /// Customer's date of birth.
        /// </summary>
        [JsonPropertyName("dob")]
        public SetupIntentPaymentMethodDataKlarnaDobOptions Dob { get; set; }
    }
}
