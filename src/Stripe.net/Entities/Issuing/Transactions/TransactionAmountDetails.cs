// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class TransactionAmountDetails : StripeEntity<TransactionAmountDetails>
    {
        /// <summary>
        /// The fee charged by the ATM for the cash withdrawal.
        /// </summary>
        [JsonPropertyName("atm_fee")]
        public long? AtmFee { get; set; }
    }
}
