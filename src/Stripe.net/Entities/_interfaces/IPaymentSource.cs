namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// Resources that implement this interface can be used as payment sources when creating
    /// charges.
    /// <para>Possible concrete classes:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="Account" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="BankAccount" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Card" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Source" /></description>
    /// </item>
    /// </list>
    /// </summary>
    [JsonConverter(typeof(StripeObjectConverter<IPaymentSource>))]
    public interface IPaymentSource : IStripeEntity, IHasId, IHasObject
    {
    }
}
