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

        public void CompareCard();

        public bool CheckPileCardCount();
    }
}
