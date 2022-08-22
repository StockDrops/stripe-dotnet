// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentMandateDataCustomerAcceptanceOnlineOptions : INestedOptions
    {
        /// <summary>
        /// The IP address from which the Mandate was accepted by the customer.
        /// </summary>
        [JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The user agent of the browser from which the Mandate was accepted by the customer.
        /// </summary>
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
