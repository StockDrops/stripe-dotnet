namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// Resources that implement this interface can be used as external accounts, i.e. they can
    /// be attached to a Stripe account to receive payouts.
    /// <para>Possible concrete classes:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="BankAccount" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Card" /></description>
    /// </item>
    /// </list>
    /// </summary>
    [JsonConverter(typeof(StripeObjectConverter<IExternalAccount>))]
    public interface IExternalAccount : IStripeEntity, IHasId, IHasObject
    {
        Account Account { get; }

        string AccountId { get; }
    }
}
