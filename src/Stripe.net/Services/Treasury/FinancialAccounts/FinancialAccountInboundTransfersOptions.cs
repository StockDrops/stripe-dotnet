// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountInboundTransfersOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH Debits via the InboundTransfers API.
        /// </summary>
        [JsonPropertyName("ach")]
        public FinancialAccountInboundTransfersAchOptions Ach { get; set; }
    }
}
