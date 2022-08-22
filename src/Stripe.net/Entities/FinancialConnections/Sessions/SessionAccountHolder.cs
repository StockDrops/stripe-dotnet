// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SessionAccountHolder : StripeEntity<SessionAccountHolder>
    {
        #region Expandable Account

        /// <summary>
        /// (ID of the Account)
        /// The ID of the Stripe account this account belongs to. Should only be present if
        /// <c>account_holder.type</c> is <c>account</c>.
        /// </summary>
        [JsonIgnore]
        public string AccountId
        {
            get => this.InternalAccount?.Id;
            set => this.InternalAccount = SetExpandableFieldId(value, this.InternalAccount);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Stripe account this account belongs to. Should only be present if
        /// <c>account_holder.type</c> is <c>account</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account Account
        {
            get => this.InternalAccount?.ExpandedObject;
            set => this.InternalAccount = SetExpandableFieldObject(value, this.InternalAccount);
        }

        [JsonPropertyName("account")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalAccount { get; set; }
        #endregion

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the Stripe customer this account belongs to. Present if and only if
        /// <c>account_holder.type</c> is <c>customer</c>.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Stripe customer this account belongs to. Present if and only if
        /// <c>account_holder.type</c> is <c>customer</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonPropertyName("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// Type of account holder that this account belongs to.
        /// One of: <c>account</c>, or <c>customer</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
