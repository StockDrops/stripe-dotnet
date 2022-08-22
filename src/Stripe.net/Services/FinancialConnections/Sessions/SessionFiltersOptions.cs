// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SessionFiltersOptions : INestedOptions
    {
        /// <summary>
        /// List of countries from which to collect accounts.
        /// </summary>
        [JsonPropertyName("countries")]
        public List<string> Countries { get; set; }
    }
}
