// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionCustomerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Customer's email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
