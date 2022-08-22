// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class FinancialAccountBalance : StripeEntity<FinancialAccountBalance>
    {
        /// <summary>
        /// Funds the user can spend right now.
        /// </summary>
        [JsonPropertyName("cash")]
        public Dictionary<string, long> Cash { get; set; }

        /// <summary>
        /// Funds not spendable yet, but will become available at a later time.
        /// </summary>
        [JsonPropertyName("inbound_pending")]
        public Dictionary<string, long> InboundPending { get; set; }

        /// <summary>
        /// Funds in the account, but not spendable because they are being held for pending outbound
        /// flows.
        /// </summary>
        [JsonPropertyName("outbound_pending")]
        public Dictionary<string, long> OutboundPending { get; set; }
    }
}
