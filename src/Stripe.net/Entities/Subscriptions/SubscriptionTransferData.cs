// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;
    using Stripe.Infrastructure.JsonConverters;

    public class SubscriptionTransferData : StripeEntity<SubscriptionTransferData>
    {
        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the destination account. By default, the entire amount is transferred to the
        /// destination.
        /// </summary>
        [JsonPropertyName("amount_percent")]
        [JsonConverter(typeof(StringDecimalConverter))]
        public decimal? AmountPercent { get; set; }

        #region Expandable Destination

        /// <summary>
        /// (ID of the Account)
        /// The account where funds from the payment will be transferred to upon payment success.
        /// </summary>
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// The account where funds from the payment will be transferred to upon payment success.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonPropertyName("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion
    }
}
