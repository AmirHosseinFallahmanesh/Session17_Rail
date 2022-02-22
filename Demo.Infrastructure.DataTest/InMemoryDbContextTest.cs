using Demo.Infrastructure.Data;
using System;
using Xunit;

namespace Demo.Infrastructure.DataTest
{

    public class InMemoryDbContextFixture:IDisposable
    {
        public InMemoryDbContextFixture()
        {
            Context = new InMemoryDbContext();
        }

        public InMemoryDbContext Context { get; private set; }

        public void Dispose()
        {
        }
    }
    public class InMemoryDbContextTest:IClassFixture<InMemoryDbContextFixture>
    {
        private readonly InMemoryDbContextFixture fixture;

        public InMemoryDbContextTest(InMemoryDbContextFixture fixture)
        {

            this.fixture = fixture;
        }
        [Fact]
        public void WithnoItems_CountShouldReturnZero()
        {

            int count = fixture.Context.Users.Count;
            Assert.Equal(0, count);
        }

        [Fact]
        public void AfterAddItem_CountShouldReturnOne()
        {

            fixture.Context.Users.Add(new User());
            int count = fixture.Context.Users.Count;
            Assert.Equal(1,count);
        }
    }
}
