// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentPaymentMethodDataBacsDebitOptions : INestedOptions
    {
        /// <summary>
        /// Account number of the bank account that the funds will be debited from.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Sort code of the bank account. (e.g., <c>10-20-30</c>).
        /// </summary>
        [JsonPropertyName("sort_code")]
        public string SortCode { get; set; }
    }
}
