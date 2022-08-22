// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentMethodAttachOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the customer to which to attach the PaymentMethod.
        /// </summary>
        [JsonPropertyName("customer")]
        public string Customer { get; set; }
    }
}
