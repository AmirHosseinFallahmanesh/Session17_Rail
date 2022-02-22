using Demo.Infrastructure.Data;
using Xunit;

namespace Demo.Infrastructure.DataTest
{
    [Collection("Context collection")]
    public class InMemoryDbContextShare1Test 
    {
        private readonly InMemoryDbContextFixture fixture;

        public InMemoryDbContextShare1Test(InMemoryDbContextFixture fixture)
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
            Assert.Equal(1, count);
        }
    }
}
