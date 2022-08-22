// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class InvoiceTransferData : StripeEntity<InvoiceTransferData>
    {
        /// <summary>
        /// The amount in %s that will be transferred to the destination account when the invoice is
        /// paid. By default, the entire amount is transferred to the destination.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

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
        [JsonInclude]
        public ExpandableField<Account> InternalDestination { get; private set; }
        #endregion
    }
}
