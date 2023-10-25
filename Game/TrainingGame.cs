using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class TrainingGame : Game
    {
        public TrainingGame(BasicAccount player1, BasicAccount player2, Victory winner)
        {
            Player1 = player1;
            Player2 = player2;
            Winner = winner;
            RatingForGame = 0;
        }
        public override int GetRatingForGame(Players player)
        {
            //rating is not allowed in training game
            return RatingForGame;
        }
    }
}
