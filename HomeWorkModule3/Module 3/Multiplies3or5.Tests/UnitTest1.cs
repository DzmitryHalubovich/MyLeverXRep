using NUnit.Framework;
using Multiplies3or5;

namespace Multiplies3or5.Tests
{
    public class Tests
    {
        [TestCase(10, 23)]
        [TestCase(16, 60)]
        [TestCase(12, 33)]
        public void Multiplies_Sum_Multiple3or5(int input, int expected)
        {
            //Arrange
            var test = new Multiplies();

            var multiplies = new Multiplies();

            //Act

            var actual = multiplies.Sum(input);

            //Assert
            Assert.AreEqual(actual, expected);

        }
    }
}