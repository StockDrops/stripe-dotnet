// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class FinancialAccountFinancialAddress : StripeEntity<FinancialAccountFinancialAddress>
    {
        /// <summary>
        /// ABA Records contain U.S. bank account details per the ABA format.
        /// </summary>
        [JsonPropertyName("aba")]
        public FinancialAccountFinancialAddressAba Aba { get; set; }

        /// <summary>
        /// The list of networks that the address supports.
        /// </summary>
        [JsonPropertyName("supported_networks")]
        public List<string> SupportedNetworks { get; set; }

        /// <summary>
        /// The type of financial address.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
