// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// This is an object representing a Stripe account. You can retrieve it to see properties
    /// on the account like its current e-mail address or if the account is enabled yet to make
    /// live charges.
    ///
    /// Some properties, marked below, are available only to platforms that want to <a
    /// href="https://stripe.com/docs/connect/accounts">create and manage Express or Custom
    /// accounts</a>.
    /// </summary>
    public class Account : StripeEntity<Account>, IHasId, IHasMetadata, IHasObject, IPaymentSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Business information about the account.
        /// </summary>
        [JsonPropertyName("business_profile")]
        public AccountBusinessProfile BusinessProfile { get; set; }

        /// <summary>
        /// The business type.
        /// One of: <c>company</c>, <c>government_entity</c>, <c>individual</c>, or
        /// <c>non_profit</c>.
        /// </summary>
        [JsonPropertyName("business_type")]
        public string BusinessType { get; set; }

        [JsonPropertyName("capabilities")]
        public AccountCapabilities Capabilities { get; set; }

        /// <summary>
        /// Whether the account can create live charges.
        /// </summary>
        [JsonPropertyName("charges_enabled")]
        public bool ChargesEnabled { get; set; }

        [JsonPropertyName("company")]
        public AccountCompany Company { get; set; }

        [JsonPropertyName("controller")]
        public AccountController Controller { get; set; }

        /// <summary>
        /// The account's country.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Time at which the account was connected. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter ISO currency code representing the default currency for the account. This
        /// must be a currency that <a href="https://stripe.com/docs/payouts">Stripe supports in the
        /// account's country</a>.
        /// </summary>
        [JsonPropertyName("default_currency")]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonPropertyName("deleted")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Whether account details have been submitted. Standard accounts cannot receive payouts
        /// before this is true.
        /// </summary>
        [JsonPropertyName("details_submitted")]
        public bool DetailsSubmitted { get; set; }

        /// <summary>
        /// An email address associated with the account. You can treat this as metadata: it is not
        /// used for authentication or messaging account holders.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// External accounts (bank accounts and debit cards) currently attached to this account.
        /// </summary>
        [JsonPropertyName("external_accounts")]
        public StripeList<IExternalAccount> ExternalAccounts { get; set; }

        [JsonPropertyName("future_requirements")]
        public AccountFutureRequirements FutureRequirements { get; set; }

        /// <summary>
        /// This is an object representing a person associated with a Stripe account.
        ///
        /// A platform cannot access a Standard or Express account's persons after the account
        /// starts onboarding, such as after generating an account link for the account. See the <a
        /// href="https://stripe.com/docs/connect/standard-accounts">Standard onboarding</a> or <a
        /// href="https://stripe.com/docs/connect/express-accounts">Express onboarding
        /// documentation</a> for information about platform pre-filling and account onboarding
        /// steps.
        ///
        /// Related guide: <a
        /// href="https://stripe.com/docs/connect/identity-verification-api#person-information">Handling
        /// Identity Verification with the API</a>.
        /// </summary>
        [JsonPropertyName("individual")]
        public Person Individual { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Whether Stripe can send payouts to this account.
        /// </summary>
        [JsonPropertyName("payouts_enabled")]
        public bool PayoutsEnabled { get; set; }

        [JsonPropertyName("requirements")]
        public AccountRequirements Requirements { get; set; }

        /// <summary>
        /// Options for customizing how the account functions within Stripe.
        /// </summary>
        [JsonPropertyName("settings")]
        public AccountSettings Settings { get; set; }

        [JsonPropertyName("tos_acceptance")]
        public AccountTosAcceptance TosAcceptance { get; set; }

        /// <summary>
        /// The Stripe account type. Can be <c>standard</c>, <c>express</c>, or <c>custom</c>.
        /// One of: <c>custom</c>, <c>express</c>, or <c>standard</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
