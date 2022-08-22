namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AddressJapan : Address
    {
        [JsonPropertyName("town")]
        public string Town { get; set; }
    }
}
