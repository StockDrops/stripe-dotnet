// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class OutboundPaymentDestinationPaymentMethodDataBillingDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Billing address.
        /// </summary>
        [JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

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

        /// <summary>
        /// Billing phone number (including extension).
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
