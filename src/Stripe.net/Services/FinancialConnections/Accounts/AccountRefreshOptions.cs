// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class AccountRefreshOptions : BaseOptions
    {
        /// <summary>
        /// The list of account features that you would like to refresh. Either: <c>balance</c> or
        /// <c>ownership</c>.
        /// </summary>
        [JsonPropertyName("features")]
        public List<string> Features { get; set; }
    }
}
