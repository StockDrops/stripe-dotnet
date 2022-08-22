namespace StripeTests.Identity
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe.Identity;
    using Xunit;

    public class VerificationSessionTest : BaseStripeTest
    {
        public VerificationSessionTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/identity/verification_sessions/vs_123");
            var verificationSession = JsonSerializer.Deserialize<VerificationSession>(json);
            Assert.NotNull(verificationSession);
            Assert.IsType<VerificationSession>(verificationSession);
            Assert.NotNull(verificationSession.Id);
            Assert.Equal("identity.verification_session", verificationSession.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "last_verification_report",
            };

            string json = this.GetFixture("/v1/identity/verification_sessions/vs_123", expansions);
            var verificationSession = JsonSerializer.Deserialize<VerificationSession>(json);
            Assert.NotNull(verificationSession);
            Assert.IsType<VerificationSession>(verificationSession);
            Assert.NotNull(verificationSession.Id);
            Assert.Equal("identity.verification_session", verificationSession.Object);

            Assert.IsType<VerificationReport>(verificationSession.LastVerificationReport);
            Assert.NotNull(verificationSession.LastVerificationReport.Id);
            Assert.Equal("identity.verification_report", verificationSession.LastVerificationReport.Object);
        }
    }
}
