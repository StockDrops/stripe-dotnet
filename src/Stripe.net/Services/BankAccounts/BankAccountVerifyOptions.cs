// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class BankAccountVerifyOptions : BaseOptions
    {
        /// <summary>
        /// Two positive integers, in <em>cents</em>, equal to the values of the microdeposits sent
        /// to the bank account.
        /// </summary>
        [JsonPropertyName("amounts")]
        public List<long> Amounts { get; set; }
    }
}
