// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettingsPayoutsSchedule : StripeEntity<AccountSettingsPayoutsSchedule>
    {
        /// <summary>
        /// The number of days charges for the account will be held before being paid out.
        /// </summary>
        [JsonPropertyName("delay_days")]
        public long DelayDays { get; set; }

        /// <summary>
        /// How frequently funds will be paid out. One of <c>manual</c> (payouts only created via
        /// API call), <c>daily</c>, <c>weekly</c>, or <c>monthly</c>.
        /// </summary>
        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The day of the month funds will be paid out. Only shown if <c>interval</c> is monthly.
        /// Payouts scheduled between the 29th and 31st of the month are sent on the last day of
        /// shorter months.
        /// </summary>
        [JsonPropertyName("monthly_anchor")]
        public long MonthlyAnchor { get; set; }

        /// <summary>
        /// The day of the week funds will be paid out, of the style 'monday', 'tuesday', etc. Only
        /// shown if <c>interval</c> is weekly.
        /// </summary>
        [JsonPropertyName("weekly_anchor")]
        public string WeeklyAnchor { get; set; }
    }
}
