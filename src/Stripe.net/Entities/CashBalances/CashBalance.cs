// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A customer's <c>Cash balance</c> represents real funds. Customers can add funds to their
    /// cash balance by sending a bank transfer. These funds can be used for payment and can
    /// eventually be paid out to your bank account.
    /// </summary>
    public class CashBalance : StripeEntity<CashBalance>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// A hash of all cash balances available to this customer. You cannot delete a customer
        /// with any cash balances, even if the balance is 0. Amounts are represented in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonPropertyName("available")]
        public Dictionary<string, long> Available { get; set; }

        /// <summary>
        /// The ID of the customer whose cash balance this object represents.
        /// </summary>
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonPropertyName("settings")]
        public CashBalanceSettings Settings { get; set; }
    }
}
