// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ChargeLevel3Options : INestedOptions
    {
        [JsonPropertyName("customer_reference")]
        public string CustomerReference { get; set; }

        [JsonPropertyName("line_items")]
        public List<ChargeLevel3LineItemOptions> LineItems { get; set; }

        [JsonPropertyName("merchant_reference")]
        public string MerchantReference { get; set; }

        [JsonPropertyName("shipping_address_zip")]
        public string ShippingAddressZip { get; set; }

        [JsonPropertyName("shipping_amount")]
        public long? ShippingAmount { get; set; }

        [JsonPropertyName("shipping_from_zip")]
        public string ShippingFromZip { get; set; }
    }
}
