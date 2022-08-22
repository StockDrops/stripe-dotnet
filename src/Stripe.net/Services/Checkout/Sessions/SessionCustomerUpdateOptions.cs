// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionCustomerUpdateOptions : INestedOptions
    {
        /// <summary>
        /// Describes whether Checkout saves the billing address onto <c>customer.address</c>. To
        /// always collect a full billing address, use <c>billing_address_collection</c>. Defaults
        /// to <c>never</c>.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Describes whether Checkout saves the name onto <c>customer.name</c>. Defaults to
        /// <c>never</c>.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Describes whether Checkout saves shipping information onto <c>customer.shipping</c>. To
        /// collect shipping information, use <c>shipping_address_collection</c>. Defaults to
        /// <c>never</c>.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonPropertyName("shipping")]
        public string Shipping { get; set; }
    }
}
