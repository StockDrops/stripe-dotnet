namespace Stripe
{
    using System.Text.Json.Serialization;

    public class BankAccountListOptions : ListOptions
    {
        [JsonPropertyName("object")]
        internal string Object => "bank_account";
    }
}
