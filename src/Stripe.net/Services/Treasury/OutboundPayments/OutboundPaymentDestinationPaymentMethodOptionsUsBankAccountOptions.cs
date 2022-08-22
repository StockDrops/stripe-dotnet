// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class OutboundPaymentDestinationPaymentMethodOptionsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// The US bank account network that must be used for this OutboundPayment. If not set, we
        /// will default to the PaymentMethod's preferred network.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
