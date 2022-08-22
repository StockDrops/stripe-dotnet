// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class InvoiceLineItemCustomerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The customer's address.
        /// </summary>
        [JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The customer's shipping information. Appears on invoices emailed to this customer.
        /// </summary>
        [JsonPropertyName("shipping")]
        public ShippingOptions Shipping { get; set; }

        /// <summary>
        /// Tax details about the customer.
        /// </summary>
        [JsonPropertyName("tax")]
        public InvoiceLineItemCustomerDetailsTaxOptions Tax { get; set; }

        /// <summary>
        /// The customer's tax exemption. One of <c>none</c>, <c>exempt</c>, or <c>reverse</c>.
        /// </summary>
        [JsonPropertyName("tax_exempt")]
        public string TaxExempt { get; set; }

        /// <summary>
        /// The customer's tax IDs.
        /// </summary>
        [JsonPropertyName("tax_ids")]
        public List<InvoiceLineItemCustomerDetailsTaxIdOptions> TaxIds { get; set; }
    }
}
