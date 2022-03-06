using NUnit.Framework;
using NumericalsOfaString;

namespace Numericals.Tests
{
    public class Tests
    {
       
        [Test]
        public void Numericals_GetNumericalString_NumericalString()
        {
            //Arrange
            var numerical = new Numericals();
            string _testString = "Hello, world";
            string _expectedString = "111211112131";

            //Act

            var actualString = numerical.GetNumericalString(_testString);

            //Assert

            Assert.Equal(_expectedString, actualString);

        }
    }
}