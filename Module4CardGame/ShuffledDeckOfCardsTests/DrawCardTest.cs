using Module4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShuffledDeckOfCardsTests
{
    public class DrawCardTest
    {
        [Fact]
        public void GameProgram_TryGetCardFromEmptyPile_AddDiscardPileIntoDrawPile()
        {
            //Arrange
            // List<int> player2 = shuffle.GetRange(5, 5); 
            //MyList<int> discardPile1 = new MyList<int>();

            List<int> drawPile = new List<int>();
            MyList<int> discardPile = new MyList<int>() {4,6,7,3,1,4,9,8,2,1};

            //Act
            var countElem = drawPile.Count();
            drawPile.AddRange(discardPile);

            //Assert
            Assert.Equal(0, countElem);
            Assert.Equal(10, drawPile.Count);

        }
    }
}
