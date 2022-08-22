// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The account holder to link accounts for.
        /// </summary>
        [JsonPropertyName("account_holder")]
        public SessionAccountHolderOptions AccountHolder { get; set; }

        /// <summary>
        /// Filters to restrict the kinds of accounts to collect.
        /// </summary>
        [JsonPropertyName("filters")]
        public SessionFiltersOptions Filters { get; set; }

        /// <summary>
        /// List of data features that you would like to request access to.
        ///
        /// Possible values are <c>balances</c>, <c>transactions</c>, <c>ownership</c>, and
        /// <c>payment_method</c>.
        /// </summary>
        [JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// For webview integrations only. Upon completing OAuth login in the native browser, the
        /// user will be redirected to this URL to return to your app.
        /// </summary>
        [JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}
