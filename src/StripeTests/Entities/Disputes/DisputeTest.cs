namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class DisputeTest : BaseStripeTest
    {
        public DisputeTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/disputes/dp_123");
            var dispute = JsonSerializer.Deserialize<Dispute>(json);
            Assert.NotNull(dispute);
            Assert.IsType<Dispute>(dispute);
            Assert.NotNull(dispute.Id);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "charge",
              "payment_intent",
            };

            string json = this.GetFixture("/v1/disputes/dp_123", expansions);
            var dispute = JsonSerializer.Deserialize<Dispute>(json);
            Assert.NotNull(dispute);
            Assert.IsType<Dispute>(dispute);
            Assert.NotNull(dispute.Id);
            Assert.Equal("dispute", dispute.Object);

            Assert.NotNull(dispute.Charge);
            Assert.Equal("charge", dispute.Charge.Object);

            Assert.NotNull(dispute.PaymentIntent);
            Assert.Equal("payment_intent", dispute.PaymentIntent.Object);
        }
    }
}
