namespace Stripe.Infrastructure
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Used to indicate that a particular property is allowed to have a name that isn't a strict
    /// <c>snake_case</c> -> <c>CamelCase</c> conversion from the JSON name defined its
    /// <see cref="JsonPropertyNameAttribute" /> property.
    /// </summary>
    /// <remarks>
    /// This is only used for an internal wholesome test.
    /// </remarks>
    [System.AttributeUsage(System.AttributeTargets.Property)]
    internal class AllowNameMismatch : System.Attribute
    {
    }
}
