// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountStatusDetails : StripeEntity<FinancialAccountStatusDetails>
    {
        /// <summary>
        /// Details related to the closure of this FinancialAccount.
        /// </summary>
        [JsonPropertyName("closed")]
        public FinancialAccountStatusDetailsClosed Closed { get; set; }
    }
}
