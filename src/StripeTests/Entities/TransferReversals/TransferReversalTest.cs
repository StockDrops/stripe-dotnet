namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class TransferReversalTest : BaseStripeTest
    {
        public TransferReversalTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/transfers/tr_123/reversals/trr_123");
            var transferReversal = JsonSerializer.Deserialize<TransferReversal>(json);
            Assert.NotNull(transferReversal);
            Assert.IsType<TransferReversal>(transferReversal);
            Assert.NotNull(transferReversal.Id);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "balance_transaction",
              "destination_payment_refund",
              "source_refund",
              "transfer",
            };

            string json = this.GetFixture("/v1/transfers/tr_123/reversals/trr_123", expansions);
            var transferReversal = JsonSerializer.Deserialize<TransferReversal>(json);
            Assert.NotNull(transferReversal);
            Assert.IsType<TransferReversal>(transferReversal);
            Assert.NotNull(transferReversal.Id);
            Assert.Equal("transfer_reversal", transferReversal.Object);

            Assert.NotNull(transferReversal.BalanceTransaction);
            Assert.Equal("balance_transaction", transferReversal.BalanceTransaction.Object);

            Assert.NotNull(transferReversal.DestinationPaymentRefund);
            Assert.Equal("refund", transferReversal.DestinationPaymentRefund.Object);

            Assert.NotNull(transferReversal.SourceRefund);
            Assert.Equal("refund", transferReversal.SourceRefund.Object);

            Assert.NotNull(transferReversal.Transfer);
            Assert.Equal("transfer", transferReversal.Transfer.Object);
        }
    }
}
