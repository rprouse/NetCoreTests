using Xunit;

namespace XUnit.Test.One
{
    public class SimpleTest
    {
        [Fact]
        public void TestOne()
        {
            Assert.NotNull(nameof(TestOne));
        }

        [Fact]
        public void TestTwo()
        {
            Assert.NotNull(nameof(TestTwo));
        }

        [Fact]
        public void TestThree()
        {
            Assert.NotNull(nameof(TestThree));
        }

        [Fact]
        public void TestFour()
        {
            Assert.NotNull(nameof(TestFour));
        }

        [Fact]
        public void TestFive()
        {
            Assert.NotNull(nameof(TestFive));
        }
    }
}
