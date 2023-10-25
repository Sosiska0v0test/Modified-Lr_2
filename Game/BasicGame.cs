using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class BasicGame : Game
    {
        public BasicGame(BasicAccount player1, BasicAccount player2, int ratingForGame, Victory winner)
        {
            Player1 = player1;
            Player2 = player2;
            RatingForGame = ratingForGame;
            Winner = winner;
        }

        public override int GetRatingForGame(Players player)
        {
            return RatingForGame;
        }
    }
}
