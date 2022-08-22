// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class PaymentMethodSepaDebitGeneratedFrom : StripeEntity<PaymentMethodSepaDebitGeneratedFrom>
    {
        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// The ID of the Charge that generated this PaymentMethod, if any.
        /// </summary>
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Charge that generated this PaymentMethod, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonPropertyName("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        [JsonInclude]
        public ExpandableField<Charge> InternalCharge { get; private set; }
        #endregion

        #region Expandable SetupAttempt

        /// <summary>
        /// (ID of the SetupAttempt)
        /// The ID of the SetupAttempt that generated this PaymentMethod, if any.
        /// </summary>
        [JsonIgnore]
        public string SetupAttemptId
        {
            get => this.InternalSetupAttempt?.Id;
            set => this.InternalSetupAttempt = SetExpandableFieldId(value, this.InternalSetupAttempt);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the SetupAttempt that generated this PaymentMethod, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public SetupAttempt SetupAttempt
        {
            get => this.InternalSetupAttempt?.ExpandedObject;
            set => this.InternalSetupAttempt = SetExpandableFieldObject(value, this.InternalSetupAttempt);
        }

        [JsonPropertyName("setup_attempt")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupAttempt>))]
        [JsonInclude]
        public ExpandableField<SetupAttempt> InternalSetupAttempt { get; private set; }
        #endregion
    }
}
