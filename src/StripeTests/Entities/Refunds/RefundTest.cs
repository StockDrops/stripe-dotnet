namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class RefundTest : BaseStripeTest
    {
        public RefundTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/refunds/re_123");
            var refund = JsonSerializer.Deserialize<Refund>(json);
            Assert.NotNull(refund);
            Assert.IsType<Refund>(refund);
            Assert.NotNull(refund.Id);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "balance_transaction",
              "charge",
              "failure_balance_transaction",
              "payment_intent",
              "source_transfer_reversal",
              "transfer_reversal",
            };

            string json = this.GetFixture("/v1/refunds/re_123", expansions);
            var refund = JsonSerializer.Deserialize<Refund>(json);
            Assert.NotNull(refund);
            Assert.IsType<Refund>(refund);
            Assert.NotNull(refund.Id);
            Assert.Equal("refund", refund.Object);

            Assert.NotNull(refund.BalanceTransaction);
            Assert.Equal("balance_transaction", refund.BalanceTransaction.Object);

            Assert.NotNull(refund.Charge);
            Assert.Equal("charge", refund.Charge.Object);

            Assert.NotNull(refund.FailureBalanceTransaction);
            Assert.Equal("balance_transaction", refund.FailureBalanceTransaction.Object);

            Assert.NotNull(refund.PaymentIntent);
            Assert.Equal("payment_intent", refund.PaymentIntent.Object);

            Assert.NotNull(refund.SourceTransferReversal);
            Assert.Equal("transfer_reversal", refund.SourceTransferReversal.Object);

            Assert.NotNull(refund.SourceTransferReversal);
            Assert.Equal("transfer_reversal", refund.SourceTransferReversal.Object);
        }
    }
}
