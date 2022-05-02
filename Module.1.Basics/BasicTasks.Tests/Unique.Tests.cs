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
    class UniqueTests
    {
        [TestCaseSource("testCaseData")]
        public void Unique_uniq_OnlyUniqInOrderWords(string inputTestArray, List<char> expectedOutputList)
        {
            //Arrange
            Unique uniqArr1 = new Unique();

            //Act
            var GetUniqArrOfChars = uniqArr1.uniq<char>(inputTestArray);

            //Assert
            Assert.AreEqual(expectedOutputList, GetUniqArrOfChars);
        }

        static IEnumerable<TestCaseData> testCaseData()
        {
            yield return new TestCaseData("AAAABBBBCCDAABBB", new List<char> { 'A', 'B', 'C', 'D', 'A', 'B' });
        }
    }
}
