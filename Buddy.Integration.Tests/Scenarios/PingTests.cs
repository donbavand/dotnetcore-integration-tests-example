using System.Net;
using System.Threading.Tasks;
using Buddy.Integration.Tests.Fixtures;
using FluentAssertions;
using Xunit;

namespace Buddy.Integration.Tests.Scenarios
{
    [Collection("SystemCollection")]
    public class PingTests
    {
        public readonly TestContext Context;

        public PingTests(TestContext context)
        {
            Context = context;
        }

        [Fact]
        public async Task PingReturnsOkResponse()
        {
            var response = await Context.Client.GetAsync("/ping");

            response.EnsureSuccessStatusCode();

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}