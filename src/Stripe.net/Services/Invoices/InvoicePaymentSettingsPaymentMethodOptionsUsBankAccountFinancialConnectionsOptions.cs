// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions : INestedOptions
    {
        /// <summary>
        /// The list of permissions to request. If this parameter is passed, the
        /// <c>payment_method</c> permission must be included. Valid permissions include:
        /// <c>balances</c>, <c>ownership</c>, <c>payment_method</c>, and <c>transactions</c>.
        /// </summary>
        [JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }
    }
}
