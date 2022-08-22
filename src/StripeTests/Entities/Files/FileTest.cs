namespace StripeTests
{
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class FileTest : BaseStripeTest
    {
        public FileTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/files/file_123");
            var file = JsonConvert.DeserializeObject<File>(json);
            Assert.NotNull(file);
            Assert.IsType<File>(file);
            Assert.NotNull(file.Id);
            Assert.Equal("file", file.Object);
        }
    }
}
