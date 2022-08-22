namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class InvoiceTaxAmount : StripeEntity<InvoiceTaxAmount>
    {
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonPropertyName("inclusive")]
        public bool Inclusive { get; set; }

        #region Expandable TaxRate

        [JsonIgnore]
        public string TaxRateId
        {
            get => this.InternalTaxRate?.Id;
            set => this.InternalTaxRate = SetExpandableFieldId(value, this.InternalTaxRate);
        }

        [JsonIgnore]
        public TaxRate TaxRate
        {
            get => this.InternalTaxRate?.ExpandedObject;
            set => this.InternalTaxRate = SetExpandableFieldObject(value, this.InternalTaxRate);
        }

        [JsonPropertyName("tax_rate")]
        [JsonConverter(typeof(ExpandableFieldConverter<TaxRate>))]
        internal ExpandableField<TaxRate> InternalTaxRate { get; set; }
        #endregion
    }
}
