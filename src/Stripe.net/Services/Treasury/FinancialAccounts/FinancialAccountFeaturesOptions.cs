// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Encodes the FinancialAccount's ability to be used with the Issuing product, including
        /// attaching cards to and drawing funds from the FinancialAccount.
        /// </summary>
        [JsonPropertyName("card_issuing")]
        public FinancialAccountFeaturesCardIssuingOptions CardIssuing { get; set; }

        /// <summary>
        /// Represents whether this FinancialAccount is eligible for deposit insurance. Various
        /// factors determine the insurance amount.
        /// </summary>
        [JsonPropertyName("deposit_insurance")]
        public FinancialAccountFeaturesDepositInsuranceOptions DepositInsurance { get; set; }

        /// <summary>
        /// Contains Features that add FinancialAddresses to the FinancialAccount.
        /// </summary>
        [JsonPropertyName("financial_addresses")]
        public FinancialAccountFeaturesFinancialAddressesOptions FinancialAddresses { get; set; }

        /// <summary>
        /// Contains settings related to adding funds to a FinancialAccount from another Account
        /// with the same owner.
        /// </summary>
        [JsonPropertyName("inbound_transfers")]
        public FinancialAccountFeaturesInboundTransfersOptions InboundTransfers { get; set; }

        /// <summary>
        /// Represents the ability for the FinancialAccount to send money to, or receive money from
        /// other FinancialAccounts (for example, via OutboundPayment).
        /// </summary>
        [JsonPropertyName("intra_stripe_flows")]
        public FinancialAccountFeaturesIntraStripeFlowsOptions IntraStripeFlows { get; set; }

        /// <summary>
        /// Includes Features related to initiating money movement out of the FinancialAccount to
        /// someone else's bucket of money.
        /// </summary>
        [JsonPropertyName("outbound_payments")]
        public FinancialAccountFeaturesOutboundPaymentsOptions OutboundPayments { get; set; }

        /// <summary>
        /// Contains a Feature and settings related to moving money out of the FinancialAccount into
        /// another Account with the same owner.
        /// </summary>
        [JsonPropertyName("outbound_transfers")]
        public FinancialAccountFeaturesOutboundTransfersOptions OutboundTransfers { get; set; }
    }
}
