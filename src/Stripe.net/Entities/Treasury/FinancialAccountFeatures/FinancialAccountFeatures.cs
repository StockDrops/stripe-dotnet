// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Encodes whether a FinancialAccount has access to a particular Feature, with a
    /// <c>status</c> enum and associated <c>status_details</c>. Stripe or the platform can
    /// control Features via the requested field.
    /// </summary>
    public class FinancialAccountFeatures : StripeEntity<FinancialAccountFeatures>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonPropertyName("card_issuing")]
        public FinancialAccountFeaturesCardIssuing CardIssuing { get; set; }

        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonPropertyName("deposit_insurance")]
        public FinancialAccountFeaturesDepositInsurance DepositInsurance { get; set; }

        /// <summary>
        /// Settings related to Financial Addresses features on a Financial Account.
        /// </summary>
        [JsonPropertyName("financial_addresses")]
        public FinancialAccountFeaturesFinancialAddresses FinancialAddresses { get; set; }

        /// <summary>
        /// InboundTransfers contains inbound transfers features for a FinancialAccount.
        /// </summary>
        [JsonPropertyName("inbound_transfers")]
        public FinancialAccountFeaturesInboundTransfers InboundTransfers { get; set; }

        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonPropertyName("intra_stripe_flows")]
        public FinancialAccountFeaturesIntraStripeFlows IntraStripeFlows { get; set; }

        /// <summary>
        /// Settings related to Outbound Payments features on a Financial Account.
        /// </summary>
        [JsonPropertyName("outbound_payments")]
        public FinancialAccountFeaturesOutboundPayments OutboundPayments { get; set; }

        /// <summary>
        /// OutboundTransfers contains outbound transfers features for a FinancialAccount.
        /// </summary>
        [JsonPropertyName("outbound_transfers")]
        public FinancialAccountFeaturesOutboundTransfers OutboundTransfers { get; set; }
    }
}
