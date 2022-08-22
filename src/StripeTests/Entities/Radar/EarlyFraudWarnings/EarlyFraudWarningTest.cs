namespace StripeTests.Radar
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Stripe.Radar;
    using Xunit;

    public class EarlyFraudWarningTest : BaseStripeTest
    {
        public EarlyFraudWarningTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/radar/early_fraud_warnings/issfr_123");
            var warning = JsonSerializer.Deserialize<EarlyFraudWarning>(json);
            Assert.NotNull(warning);
            Assert.IsType<EarlyFraudWarning>(warning);
            Assert.NotNull(warning.Id);
            Assert.Equal("radar.early_fraud_warning", warning.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "charge",
            };

            string json = this.GetFixture("/v1/radar/early_fraud_warnings/issfr_123", expansions);
            var warning = JsonSerializer.Deserialize<EarlyFraudWarning>(json);
            Assert.NotNull(warning);
            Assert.IsType<EarlyFraudWarning>(warning);
            Assert.NotNull(warning.Id);
            Assert.Equal("radar.early_fraud_warning", warning.Object);

            Assert.NotNull(warning.Charge);
            Assert.Equal("charge", warning.Charge.Object);
        }
    }
}
