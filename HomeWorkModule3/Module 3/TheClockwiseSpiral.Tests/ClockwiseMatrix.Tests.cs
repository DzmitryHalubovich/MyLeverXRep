using NUnit.Framework;
using TheClockwiseSpiral;

namespace TheClockwiseSpiral.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            //Arrange
            int N = 3;
            var matrix = new ClockwiseMatrix();
            int[,] _expectedArr = { { 1, 2, 3 },{ 8, 9, 4 },{ 7, 6, 5 } };

            //Act

            int [,] actualArr = matrix.Clockwise(N);

            //Assert

            CollectionAssert.AreEqual(_expectedArr, actualArr);
        }
    }
}