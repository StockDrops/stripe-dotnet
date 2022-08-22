// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentMethodCardChecks : StripeEntity<PaymentMethodCardChecks>
    {
        /// <summary>
        /// If a address line1 was provided, results of the check, one of <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonPropertyName("address_line1_check")]
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// If a address postal code was provided, results of the check, one of <c>pass</c>,
        /// <c>fail</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonPropertyName("address_postal_code_check")]
        public string AddressPostalCodeCheck { get; set; }

        /// <summary>
        /// If a CVC was provided, results of the check, one of <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonPropertyName("cvc_check")]
        public string CvcCheck { get; set; }
    }
}
