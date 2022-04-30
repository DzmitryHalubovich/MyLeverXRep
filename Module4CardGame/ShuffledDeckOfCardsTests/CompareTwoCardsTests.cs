using ShuffledDeckOfCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShuffledDeckOfCardsTests
{
    public class CompareTwoCards
    {
        [Fact]
        public void Game_CompareCard_higherCardShouldWin()
        {
            //Arrange
            var game = new FirstGame(2);
            //int card1 = 2;
            //int card2 = 4;


            //Act
            var result = game.CompareCard(2, 4);

            //Assert
            Assert.Equal("Player 2 wins this round", result);
        }
        
        [Fact]
        public void Game_CompareSameCard_TakeFourCardsForWinner()
        {
            //Arrange
            List<int> shufflePlayer1 = new List<int>() {1,3,4};
            List<int> shufflePlayer2 = new List<int>() {1,6,7};
            var game = new FirstGame(shufflePlayer1, shufflePlayer2);
            
            //Act
            game.MainGame();
            
            //Assert
            Assert.Equal(2, game.CountCardsSecondPlayer); //after the round the cards are not added to the played deck if the player has lost the game

        }

    }
}
