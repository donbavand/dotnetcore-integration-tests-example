using Xunit;

namespace Buddy.Integration.Tests.Fixtures
{
    [CollectionDefinition("SystemCollection")]
    public class Collection : ICollectionFixture<TestContext>
    {
        
    }
}