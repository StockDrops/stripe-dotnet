// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class BalanceIssuing : StripeEntity<BalanceIssuing>
    {
        /// <summary>
        /// Funds that are available for use.
        /// </summary>
        [JsonPropertyName("available")]
        public List<BalanceAmount> Available { get; set; }
    }
}
