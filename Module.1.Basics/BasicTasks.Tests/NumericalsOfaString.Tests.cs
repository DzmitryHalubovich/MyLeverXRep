using NETLeverXLab;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModuleOne.Tests
{
    [TestFixture]
    class NumericalsOfaStringTests
    {
        [TestCase("Hello, world", "111211112131")]
        [TestCase("aaaaaaaaaaa", "1234567891011")]
        public void NumericalsOfaString_GetNumericalString_GetCountWords(string inputString, string expectedString)
        {
            //Arrange
            var numerical = new NumericalsOfaString();

            //Act

            var actualString = numerical.GetNumericalString(inputString);

            //Assert

            Assert.AreEqual(expectedString, actualString);
        }
    }
}
