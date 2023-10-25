using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class GameHistory
    {
        private BasicAccount FirstPlayer;
        private BasicAccount SecondPlayer;
        private static int Games = 0;
        private static int temp = 0;
        private int GameID;
        private bool IsFirstPlayerWon;
        private int RatingForGame;

        public GameHistory(BasicAccount firstPlayer, BasicAccount secondPlayer, bool isFirstPlayerWon, int ratingForGame)
        {
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
            IsFirstPlayerWon = isFirstPlayerWon;
            RatingForGame = ratingForGame;
            if (temp % 2 == 1)
                Games--;
            GameID = Games;
            Games++;
            temp++;
        }

        public void ShowPlayerHistory()
        {
            Console.WriteLine("Game ID: " + GameID + "| Opponent is " + SecondPlayer.playerName +
            ". Winner of the game is " + (IsFirstPlayerWon ? FirstPlayer.playerName : SecondPlayer.playerName) +
            ". Played for " + RatingForGame + " points");
        }
        public void ShowPlayerHistoryReverse()
        {
            Console.WriteLine("Game ID: " + GameID + "| Opponent is " + FirstPlayer.playerName +
            ". Winner of the game is " + (!IsFirstPlayerWon ? FirstPlayer.playerName : SecondPlayer.playerName) +
            ". Played for " + RatingForGame + " points");
        }
    }
}
