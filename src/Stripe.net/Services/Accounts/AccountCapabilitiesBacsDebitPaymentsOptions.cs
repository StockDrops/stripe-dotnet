// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountCapabilitiesBacsDebitPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Passing true requests the capability for the account, if it is not already requested. A
        /// requested capability may not immediately become active. Any requirements to activate the
        /// capability are returned in the <c>requirements</c> arrays.
        /// </summary>
        [JsonPropertyName("requested")]
        public bool? Requested { get; set; }
    }
}
