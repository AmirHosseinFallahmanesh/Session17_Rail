using Xunit;

namespace Demo.Infrastructure.DataTest
{
    [Collection("Context collection")]
    public class InMemoryDbContextFixtureCollection : ICollectionFixture<InMemoryDbContextFixture>
    {

    }
}
