// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class FinancialAccountFeaturesDepositInsurance : StripeEntity<FinancialAccountFeaturesDepositInsurance>
    {
        /// <summary>
        /// Whether the FinancialAccount should have the Feature.
        /// </summary>
        [JsonPropertyName("requested")]
        public bool Requested { get; set; }

        /// <summary>
        /// Whether the Feature is operational.
        /// One of: <c>active</c>, <c>pending</c>, or <c>restricted</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details; includes at least one entry when the status is not <c>active</c>.
        /// </summary>
        [JsonPropertyName("status_details")]
        public List<FinancialAccountFeaturesDepositInsuranceStatusDetail> StatusDetails { get; set; }
    }
}
