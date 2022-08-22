// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class OutboundTransferDestinationPaymentMethodOptionsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// Designate the OutboundTransfer as using a US bank account network configuration.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
