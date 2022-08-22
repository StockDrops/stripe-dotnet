// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class TransactionPurchaseDetails : StripeEntity<TransactionPurchaseDetails>
    {
        /// <summary>
        /// Information about the flight that was purchased with this transaction.
        /// </summary>
        [JsonPropertyName("flight")]
        public TransactionPurchaseDetailsFlight Flight { get; set; }

        /// <summary>
        /// Information about fuel that was purchased with this transaction.
        /// </summary>
        [JsonPropertyName("fuel")]
        public TransactionPurchaseDetailsFuel Fuel { get; set; }

        /// <summary>
        /// Information about lodging that was purchased with this transaction.
        /// </summary>
        [JsonPropertyName("lodging")]
        public TransactionPurchaseDetailsLodging Lodging { get; set; }

        /// <summary>
        /// The line items in the purchase.
        /// </summary>
        [JsonPropertyName("receipt")]
        public List<TransactionPurchaseDetailsReceipt> Receipt { get; set; }

        /// <summary>
        /// A merchant-specific order number.
        /// </summary>
        [JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
