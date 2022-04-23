using Module4;
using System.Collections;
using Xunit;

namespace ShuffledDeckOfCardsTests
{
    public class ShuffledDeckOfCardsTests
    {
        [Fact]
        public void ShuffledDeckOfCards_Shuffle_GetListOf40Items()
        {
            //Arrange
            var cards = new MyList<int>();
            for (int i = 0; i < 4; i++) 
            {
                for (int j = 1; j < 11; j++)
                {
                    cards.Add(j);
                }
            }

            //Act
            var listOf40 = cards;

            //Asserts
            Assert.Equal(40, listOf40.Count);
        }

        [Fact]
        public void ShuffledDeckOfCards_GetShuffleDeck()
        {
            //Arrange
            MyList<int> listOf40 =new MyList<int>();
            var cards = new MyList<int>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    cards.Add(j);
                }
            }

            //Act
            listOf40.AddRange(cards);
            cards.Shuffle();

            //Assert
            Assert.NotEqual(cards, listOf40);
        }
    }
}