// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class FinancialAccountStatusDetailsClosed : StripeEntity<FinancialAccountStatusDetailsClosed>
    {
        /// <summary>
        /// The array that contains reasons for a FinancialAccount closure.
        /// </summary>
        [JsonPropertyName("reasons")]
        public List<string> Reasons { get; set; }
    }
}
