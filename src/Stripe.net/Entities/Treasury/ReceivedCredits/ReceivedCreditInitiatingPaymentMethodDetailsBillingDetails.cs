// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class ReceivedCreditInitiatingPaymentMethodDetailsBillingDetails : StripeEntity<ReceivedCreditInitiatingPaymentMethodDetailsBillingDetails>
    {
        [JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Full name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
