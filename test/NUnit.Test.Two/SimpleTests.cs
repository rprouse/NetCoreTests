using NUnit.Framework;

namespace NUnit.Test.One
{
    [Category("NUnit")]
    public class SimpleTest
    {
        [Test]
        public void TestOne()
        {
            Assert.Pass(nameof(TestOne));
        }

        [Test]
        public void TestTwo()
        {
            Assert.Pass(nameof(TestTwo));
        }

        [Test]
        public void TestThree()
        {
            Assert.Pass(nameof(TestThree));
        }

        [Test]
        public void TestFour()
        {
            Assert.Pass(nameof(TestFour));
        }

        [Test]
        public void TestFive()
        {
            Assert.Pass(nameof(TestFive));
        }
    }
}
