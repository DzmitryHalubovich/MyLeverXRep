using Module4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffledDeckOfCards
{
    public class Game
    {
        protected Random rand = new Random();
        protected MyList<int> pile = new MyList<int>();
    }

    public class FirstGame : Game, ICardGame
    {
        string vinner;
        int card1 = 0;
        int card2 = 0;
        List<int> player1; 
        List<int> player2; 
        MyList<int> discardPile1 = new MyList<int>();
        MyList<int> discardPile2 = new MyList<int>();
        List<int> tempPile = new List<int>();

        public FirstGame(List<int> deck1, List<int> deck2)
        {
            player1 = deck1;
            player2 = deck2;
        }

        public FirstGame(int deckSize)
        {
            CreateAndReshufflePile();
            player1 = pile.GetRange(0, deckSize/2);
            player2 = pile.GetRange(deckSize/2, deckSize/2);
        }

        public int CountCardsFirstPlayer
        {
            get { return discardPile1.Count(); }
        }

        public int CountCardsSecondPlayer
        {
            get { return player2.Count() + discardPile2.Count(); }
        }

        public void CheckBothPlayersPiles()
        {
            foreach (int i in player1) { Console.Write(i + " "); } //For debug
            Console.WriteLine();
            foreach (int i in player2) { Console.Write(i + " "); } //For debug
        }

        public bool CheckPileCardCount()
        {

            if (player1.Count == 0 && discardPile1.Count ==0)
            {
                vinner = "Player 2 wins this game!";
                return true;
            }
            else if (player2.Count == 0 && discardPile2.Count ==0)
            {
                vinner = "Player 1 wins this game!";
                return true;
            }
            if (player1.Count==0)
            {
                discardPile1.Shuffle();
                player1.AddRange(discardPile1);
                discardPile1.Clear();
            }
            if (player2.Count==0)
            {
                discardPile2.Shuffle();
                player2.AddRange(discardPile2);
                discardPile2.Clear();
            }
            return false;
        }

        public string CompareCard(int card1, int card2)
        {
            if (card1 == card2)
            {
                tempPile.Add(card1);
                tempPile.Add(card2);
                player1.RemoveAt(player1.Count-1);
                player2.RemoveAt(player2.Count-1);
                return "No winner in this round";
            }
            else if (card1>card2)
            {
                discardPile1.Add(card2);
                discardPile1.Add(card1);
                player1.RemoveAt(player1.Count-1);
                player2.RemoveAt(player2.Count-1);
                if (tempPile.Count()>0)
                {
                    discardPile1.AddRange(tempPile);
                    tempPile.Clear();
                }
                return "Player 1 wins this round";
            }
            else if(card1<card2)
            {
                discardPile2.Add(card2);
                discardPile2.Add(card1);
                player1.RemoveAt(player1.Count-1);
                player2.RemoveAt(player2.Count-1);
                if (tempPile.Count()>0)
                {
                    discardPile2.AddRange(tempPile);
                    tempPile.Clear();
                }
                return "Player 2 wins this round";
            }
            return null;
        }

        public void CreateAndReshufflePile()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    pile.Add(j);
                }
            }
            pile.Shuffle();
        }

        public string MainGame()
        {
            while (true)
            {
                if (CheckPileCardCount())
                {
                    return vinner;
                }
                card1 = player1.Last();
                card2 = player2.Last();

                Console.WriteLine($"\nPlayer 1 ({player1.Count} + {discardPile1.Count} res cards): {card1}");
                Console.WriteLine($"Player 2 ({player2.Count} + {discardPile2.Count} res cards): {card2}");
                Thread.Sleep(400);

                Console.WriteLine(CompareCard(card1, card2)); 
            }
        }
    }

}
