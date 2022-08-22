namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class ApplicationFeeTest : BaseStripeTest
    {
        public ApplicationFeeTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/application_fees/fee_123");
            var applicationFee = JsonSerializer.Deserialize<ApplicationFee>(json, new JsonSerializerOptions(StripeConfiguration.SerializerSettings));
            Assert.NotNull(applicationFee);
            Assert.IsType<ApplicationFee>(applicationFee);
            Assert.NotNull(applicationFee.Id);
            Assert.Equal("application_fee", applicationFee.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "account",
              "application",
              "balance_transaction",
              "charge",
              "originating_transaction",
            };

            string json = this.GetFixture("/v1/application_fees/fee_123", expansions);
            var applicationFee = JsonSerializer.Deserialize<ApplicationFee>(json, new JsonSerializerOptions(StripeConfiguration.SerializerSettings));
            Assert.NotNull(applicationFee);
            Assert.IsType<ApplicationFee>(applicationFee);
            Assert.NotNull(applicationFee.Id);
            Assert.Equal("application_fee", applicationFee.Object);

            Assert.NotNull(applicationFee.Account);
            Assert.Equal("account", applicationFee.Account.Object);

            Assert.NotNull(applicationFee.Application);
            Assert.Equal("application", applicationFee.Application.Object);

            Assert.NotNull(applicationFee.BalanceTransaction);
            Assert.Equal("balance_transaction", applicationFee.BalanceTransaction.Object);

            Assert.NotNull(applicationFee.Charge);
            Assert.Equal("charge", applicationFee.Charge.Object);

            Assert.NotNull(applicationFee.OriginatingTransaction);
            Assert.Equal("charge", applicationFee.OriginatingTransaction.Object);
        }
    }
}
