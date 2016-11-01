using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest.Test.One
{
    [TestClass]
    [TestCategory("MSTest")]
    public class SimpleTest
    {
        [TestMethod]
        public void TestOne()
        {
            Assert.IsNotNull(nameof(TestOne));
        }

        [TestMethod]
        public void TestTwo()
        {
            Assert.IsNotNull(nameof(TestTwo));
        }

        [TestMethod]
        public void TestThree()
        {
            Assert.IsNotNull(nameof(TestThree));
        }

        [TestMethod]
        public void TestFour()
        {
            Assert.IsNotNull(nameof(TestFour));
        }

        [TestMethod]
        public void TestFive()
        {
            Assert.IsNotNull(nameof(TestFive));
        }
    }
}
