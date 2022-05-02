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
    class TheClockwiseSpiralTests
    {
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
