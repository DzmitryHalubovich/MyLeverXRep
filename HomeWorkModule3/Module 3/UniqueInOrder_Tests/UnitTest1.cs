using NUnit.Framework;
using System.Collections.Generic;
using UniqueInOrder;

namespace UniqueInOrder_Tests
{
    public class Tests
    {
        [Test]
        public void Unique_uniqueInOrder_OnlyUniqInOrderWords()
        {
            //Arrange
            var unique = new Unique();
            string _testString = "AAAABBBBCCDAABBB";

            int[] _testArr = new int[] { 1, 2, 2, 3, 3 };
            List<object> _expectedList1 = new List<object> { 'A', 'B', 'C', 'D', 'A', 'B' };
            List<object> _expectedList2 = new List<object> { 1, 2, 3 };

            //Act
            var actualString = unique.uniqueInOrder(_testString);
            var actualArr = unique.uniqueInOrder(_testArr);


            //Assert

            Assert.AreEqual(_expectedList1, actualString);
            Assert.AreEqual(_expectedList2, actualArr);
        }
    }
}