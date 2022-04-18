using NUnit.Framework;
using NETLeverXLab;
using System.Collections.Generic;

namespace LibraryModuleOne.Tests
{
    public class MultipliesTests
    {
        [TestCase(10, 23)]
        [TestCase(16, 60)]
        [TestCase(12, 33)]
        public void Multiplies_Sum_Multiple3or5(int input, int expected)
        {
            //Arrange
            var test = new Multiplies3or5();

            //Act
            var actual = test.Sum(input);

            //Assert
            Assert.AreEqual(actual, expected);

        }
    }
}