using System;
using Xunit;

namespace XUnit.Test.One
{
    public class FailingTest
    {
        [Fact]
        public void WatchMeFail()
        {
            Assert.True(false, "Watch me fail!");
        }

        [Fact]
        public void WatchMeThrowAnException()
        {
            throw new NotImplementedException("Watch me crash and burn!");
        }

        [Fact]
        public void TestSuperHero()
        {
            var obj = new SuperHero();
            obj.Batman();
            Assert.True(true);
        }
    }

    public class SuperHero
    {
        public void Batman()
        {
            throw new Exception("Batman failed");
        }
    }
}
