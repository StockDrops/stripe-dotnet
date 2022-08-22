// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Text.Json.Serialization;

    public class InboundTransferFailureDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Reason for the failure.
        /// One of: <c>account_closed</c>, <c>account_frozen</c>, <c>bank_account_restricted</c>,
        /// <c>bank_ownership_changed</c>, <c>debit_not_authorized</c>,
        /// <c>incorrect_account_holder_address</c>, <c>incorrect_account_holder_name</c>,
        /// <c>incorrect_account_holder_tax_id</c>, <c>insufficient_funds</c>,
        /// <c>invalid_account_number</c>, <c>invalid_currency</c>, <c>no_account</c>, or
        /// <c>other</c>.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
