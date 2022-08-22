// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class OutboundPaymentDestinationPaymentMethodDataUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// Account holder type: individual or company.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonPropertyName("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// Account number of the bank account.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Account type: checkings or savings. Defaults to checking if omitted.
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// The ID of a Financial Connections Account to use as a payment method.
        /// </summary>
        [JsonPropertyName("financial_connections_account")]
        public string FinancialConnectionsAccount { get; set; }

        /// <summary>
        /// Routing number of the bank account.
        /// </summary>
        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
