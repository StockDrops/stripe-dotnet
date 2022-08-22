namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SessionDisplayItemCustom : StripeEntity<SessionDisplayItemCustom>
    {
        /// <summary>
        /// The description of the line item.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The images of the line item.
        /// </summary>
        [JsonPropertyName("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// The name of the line item.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
