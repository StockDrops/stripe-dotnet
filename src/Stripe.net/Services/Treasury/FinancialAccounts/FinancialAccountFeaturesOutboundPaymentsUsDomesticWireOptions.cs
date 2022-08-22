// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountFeaturesOutboundPaymentsUsDomesticWireOptions : INestedOptions
    {
        /// <summary>
        /// Whether the FinancialAccount should have the Feature.
        /// </summary>
        [JsonPropertyName("requested")]
        public bool? Requested { get; set; }
    }
}
