using NUnit.Framework;
using NETLeverXLab;
using System.Collections.Generic;

namespace LibraryModuleOne.Tests
{
    public class Tests
    {
        [TestCase(10, 23)]
        [TestCase(16, 60)]
        [TestCase(12, 33)]
        public void Multiplies_Sum_Multiple3or5(int input, int expected)
        {
            //Arrange
            var test = new Multiplies3or5();
            //var multiplies = new Multiplies();

            //Act
            var actual = test.Sum(input);

            //Assert
            Assert.AreEqual(actual, expected);

        }
        
        [TestCaseSource("testCaseData")]
        public void Unique_uniq_OnlyUniqInOrderWords(string inputTestArray, List<char> expectedOutputList)
        {
            //Arrange
            Unique uniqArr1 = new Unique();
            Unique uniqArr2 = new Unique();
           
            //Act
            var GetUniqArrOfChars = uniqArr1.uniq<char>(inputTestArray);

            //Assert
            Assert.AreEqual(expectedOutputList, GetUniqArrOfChars);
        }

        static IEnumerable<TestCaseData> testCaseData()
        {
            yield return new TestCaseData("AAAABBBBCCDAABBB", new List<char> { 'A', 'B', 'C', 'D', 'A', 'B' });
        }

        [TestCase("10.0.0.0", "10.0.0.50", 50)]
        [TestCase("10.0.0.0", "10.0.1.0", 256)]
        [TestCase("10.0.1.0", "10.0.0.0", 0)]
        public void CountIPAddresses_CountIP_GetCountOfIpAddresses(string firstAddress, string secondAddress, int expectedCount)
        {
            //Arrange
            CountIPAddresses countIP = new CountIPAddresses();

            //Act
            var returnValue = countIP.CountIP(firstAddress, secondAddress);

            //Assert
            Assert.AreEqual(expectedCount, returnValue);
        }

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

        [Test]
        public void TheClockwiseSpiral_Clockwise_GetSpiralMatrix()
        {
            //Arrange

            int N = 3;
            var matrix = new TheClockwiseSpiral();
            int[,] _expectedArr = { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } };

            //Act

            int[,] actualArr = matrix.Clockwise(N);

            //Assert

            CollectionAssert.AreEqual(_expectedArr, actualArr);
        }
    }
}