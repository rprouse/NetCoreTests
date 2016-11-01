using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities;

namespace MSTest.Test.One
{
    public enum TestTypes
    {
        none = 0,
        a,
        B,
        Testing,
        UnitTesting,
        integrationTesting
    }

    [TestClass]
    public class EnumToStringConverterTests
    {
        [DataTestMethod]
        [DataRow((TestTypes)10, "")]
        [DataRow(TestTypes.a, "A")]
        [DataRow(TestTypes.B, "B")]
        [DataRow(TestTypes.none, "None")]
        [DataRow(TestTypes.Testing, "Testing")]
        [DataRow(TestTypes.UnitTesting, "Unit Testing")]
        [DataRow(TestTypes.integrationTesting, "Integration Testing")]
        public void CanConvertEnumIntoFriendlyString(TestTypes value, string expected)
        {
            // Arrange/Act
            var actual = value.ToFriendlyString();

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
