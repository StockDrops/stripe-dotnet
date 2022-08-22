// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class CustomerCashBalanceTransactionAppliedToPayment : StripeEntity<CustomerCashBalanceTransactionAppliedToPayment>
    {
        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// The <a href="https://stripe.com/docs/api/payment_intents/object">Payment Intent</a> that
        /// funds were applied to.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// The <a href="https://stripe.com/docs/api/payment_intents/object">Payment Intent</a> that
        /// funds were applied to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonPropertyName("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        [JsonInclude]
        public ExpandableField<PaymentIntent> InternalPaymentIntent { get; private set; }
        #endregion
    }
}
