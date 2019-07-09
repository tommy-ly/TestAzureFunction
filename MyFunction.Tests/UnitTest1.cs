using Xunit;

namespace MyFunction.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            Assert.False(true);
        }

        [Fact]
        public void Test3()
        {
            Assert.False(false);
        }
    }
}
