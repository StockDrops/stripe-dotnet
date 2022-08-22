namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class ApplicationFeeRefundTest : BaseStripeTest
    {
        public ApplicationFeeRefundTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/application_fees/fee_123/refunds/fr_123");
            var applicationFeeRefund = JsonSerializer.Deserialize<ApplicationFeeRefund>(json);
            Assert.NotNull(applicationFeeRefund);
            Assert.IsType<ApplicationFeeRefund>(applicationFeeRefund);
            Assert.NotNull(applicationFeeRefund.Id);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }
    }
}
