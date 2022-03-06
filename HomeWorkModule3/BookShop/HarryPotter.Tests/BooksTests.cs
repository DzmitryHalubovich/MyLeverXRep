using NUnit.Framework;
using HarryPotter;
using System.Collections.Generic;

namespace HarryPotter.Tests
{
    public class Tests
    {

        [TestCase(8, 1)]
        [TestCase(15.2, 2)]
        [TestCase(21.6, 3)]
        [TestCase(25.6, 4)]
        [TestCase(30, 5)]
        public void Books_GetTotalPriceWithDiscount_GetPriceIf(decimal expectedPrice, int countOfBooks)
        {
            //Act
            var actual = Books.GetTotalPriceWithDiscount(countOfBooks);

            //Assert
            Assert.AreEqual(expectedPrice, actual);
        }

        [Test]
        public void Books_Purchase_GetTotalPrice()
        {
            //Arrange
            List<int> list = new List<int> { 1, 2, 3, 4, 4, 5 };

            //Act
            var actual = Books.Purchase(list);

            //Assert
            Assert.AreEqual(38m, actual);

        }

        [Test, TestCaseSource("testCaseData")]
        public void Books_Purchase_GetTotalPrice(decimal expectedPrice,List<int> list)
        {
            //Act
            var actual = Books.Purchase(list);

            //Assert
            Assert.AreEqual(expectedPrice, actual);
        }

        static IEnumerable<TestCaseData> testCaseData()
        {
            yield return new TestCaseData(38m, new List<int> { 1, 1, 2, 3, 4, 5 });
            yield return new TestCaseData(45.2m, new List<int> { 1, 2, 2, 3, 4, 5,5 });
            yield return new TestCaseData(60.4m, new List<int> { 1, 2, 2, 2, 3, 4, 5, 5,5 });
        }
    }
}