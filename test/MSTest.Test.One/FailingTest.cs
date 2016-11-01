using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTest.Test.One
{
    [TestClass]
    public class FailingTest
    {
        [TestMethod]
        public void WatchMeFail()
        {
            Assert.Fail("Watch me fail!");
        }

        [TestMethod]
        public void WatchMeThrowAnException()
        {
            throw new NotImplementedException("Watch me crash and burn!");
        }

        [TestMethod]
        public void TestSuperHero()
        {
            var obj = new SuperHero();
            obj.Batman();
            Assert.IsTrue(true);
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
