using Module4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffledDeckOfCards
{
    public interface ICardGame
    {
        public void CreateAndReshufflePile();

        public void CheckBothPlayersPiles();

        public string MainGame();

        public string CompareCard(int card1, int card2);

        public bool CheckPileCardCount();
    }
}
