using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    enum Victory { Player1, Player2 }
    enum Players { Player1, Player2 }

    internal abstract class Game
    {
        public BasicAccount Player1 { get;  set; }
        public BasicAccount Player2 { get;  set; }
        public int RatingForGame { get; set; }
        public Victory Winner { get;  set; }


        public abstract int GetRatingForGame(Players player);
    }
}
