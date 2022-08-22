// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// A SetupAttempt describes one attempted confirmation of a SetupIntent, whether that
    /// confirmation was successful or unsuccessful. You can use SetupAttempts to inspect
    /// details of a specific attempt at setting up a payment method using a SetupIntent.
    /// </summary>
    public class SetupAttempt : StripeEntity<SetupAttempt>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// The value of <a
        /// href="https://stripe.com/docs/api/setup_intents/object#setup_intent_object-application">application</a>
        /// on the SetupIntent at the time of this confirmation.
        /// </summary>
        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// The value of <a
        /// href="https://stripe.com/docs/api/setup_intents/object#setup_intent_object-application">application</a>
        /// on the SetupIntent at the time of this confirmation.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonPropertyName("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        [JsonInclude]
        public ExpandableField<Application> InternalApplication { get; private set; }
        #endregion

        /// <summary>
        /// If present, the SetupIntent's payment method will be attached to the in-context Stripe
        /// Account.
        ///
        /// It can only be used for this Stripe Account’s own money movement flows like
        /// InboundTransfer and OutboundTransfers. It cannot be set to true when setting up a
        /// PaymentMethod for a Customer, and defaults to false when attaching a PaymentMethod to a
        /// Customer.
        /// </summary>
        [JsonPropertyName("attach_to_self")]
        public bool AttachToSelf { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The value of <a
        /// href="https://stripe.com/docs/api/setup_intents/object#setup_intent_object-customer">customer</a>
        /// on the SetupIntent at the time of this confirmation.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The value of <a
        /// href="https://stripe.com/docs/api/setup_intents/object#setup_intent_object-customer">customer</a>
        /// on the SetupIntent at the time of this confirmation.
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
        [JsonInclude]
        public ExpandableField<Customer> InternalCustomer { get; private set; }
        #endregion

        /// <summary>
        /// Indicates the directions of money movement for which this payment method is intended to
        /// be used.
        ///
        /// Include <c>inbound</c> if you intend to use the payment method as the origin to pull
        /// funds from. Include <c>outbound</c> if you intend to use the payment method as the
        /// destination to send funds to. You can include both if you intend to use the payment
        /// method for both purposes.
        /// </summary>
        [JsonPropertyName("flow_directions")]
        public List<string> FlowDirections { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The value of <a
        /// href="https://stripe.com/docs/api/setup_intents/object#setup_intent_object-on_behalf_of">on_behalf_of</a>
        /// on the SetupIntent at the time of this confirmation.
        /// </summary>
        [JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        /// <summary>
        /// (Expanded)
        /// The value of <a
        /// href="https://stripe.com/docs/api/setup_intents/object#setup_intent_object-on_behalf_of">on_behalf_of</a>
        /// on the SetupIntent at the time of this confirmation.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonPropertyName("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        [JsonInclude]
        public ExpandableField<Account> InternalOnBehalfOf { get; private set; }
        #endregion

        #region Expandable PaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of the payment method used with this SetupAttempt.
        /// </summary>
        [JsonIgnore]
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod?.Id;
            set => this.InternalPaymentMethod = SetExpandableFieldId(value, this.InternalPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the payment method used with this SetupAttempt.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentMethod PaymentMethod
        {
            get => this.InternalPaymentMethod?.ExpandedObject;
            set => this.InternalPaymentMethod = SetExpandableFieldObject(value, this.InternalPaymentMethod);
        }

        [JsonPropertyName("payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        [JsonInclude]
        public ExpandableField<PaymentMethod> InternalPaymentMethod { get; private set; }
        #endregion

        [JsonPropertyName("payment_method_details")]
        public SetupAttemptPaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// The error encountered during this attempt to confirm the SetupIntent, if any.
        /// </summary>
        [JsonPropertyName("setup_error")]
        public StripeError SetupError { get; set; }

        #region Expandable SetupIntent

        /// <summary>
        /// (ID of the SetupIntent)
        /// ID of the SetupIntent that this attempt belongs to.
        /// </summary>
        [JsonIgnore]
        public string SetupIntentId
        {
            get => this.InternalSetupIntent?.Id;
            set => this.InternalSetupIntent = SetExpandableFieldId(value, this.InternalSetupIntent);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the SetupIntent that this attempt belongs to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public SetupIntent SetupIntent
        {
            get => this.InternalSetupIntent?.ExpandedObject;
            set => this.InternalSetupIntent = SetExpandableFieldObject(value, this.InternalSetupIntent);
        }

        [JsonPropertyName("setup_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupIntent>))]
        [JsonInclude]
        public ExpandableField<SetupIntent> InternalSetupIntent { get; private set; }
        #endregion

        /// <summary>
        /// Status of this SetupAttempt, one of <c>requires_confirmation</c>,
        /// <c>requires_action</c>, <c>processing</c>, <c>succeeded</c>, <c>failed</c>, or
        /// <c>abandoned</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The value of <a
        /// href="https://stripe.com/docs/api/setup_intents/object#setup_intent_object-usage">usage</a>
        /// on the SetupIntent at the time of this confirmation, one of <c>off_session</c> or
        /// <c>on_session</c>.
        /// </summary>
        [JsonPropertyName("usage")]
        public string Usage { get; set; }
    }
}
