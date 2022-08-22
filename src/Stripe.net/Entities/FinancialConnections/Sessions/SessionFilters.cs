// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SessionFilters : StripeEntity<SessionFilters>
    {
        /// <summary>
        /// List of countries from which to filter accounts.
        /// </summary>
        [JsonPropertyName("countries")]
        public List<string> Countries { get; set; }
    }
}
