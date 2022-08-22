// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentPaymentMethodDataKlarnaOptions : INestedOptions
    {
        /// <summary>
        /// Customer's date of birth.
        /// </summary>
        [JsonPropertyName("dob")]
        public DobOptions Dob { get; set; }
    }
}
