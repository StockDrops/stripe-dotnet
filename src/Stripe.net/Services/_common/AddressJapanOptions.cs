namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AddressJapanOptions : AddressOptions
    {
        [JsonPropertyName("town")]
        public string Town { get; set; }
    }
}
