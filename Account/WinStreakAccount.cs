using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class WinStreakAccount : BasicAccount
    {
        private const int winStreakPoins = 15;
        private int winStreak = 0;
        public WinStreakAccount(string playerName) : base(playerName) { }
        //win streak account receives bonus points when a player wins 3 or more times in a row
        public override void WinGame(Game game)
        {
            gamesCount++;
            winStreak++;
            int ratingForGame;
            if(winStreak >= 3) 
            {
                ratingForGame = winStreakPoins + game.GetRatingForGame(Players.Player1);
                if (ratingForGame < 0)
                {
                    Console.WriteLine("Game " + gamesCount + ". " + "Rating for game must be less then 0");
                    game.Player1.gamesCount--;
                    return;
                }
                Console.WriteLine(game.Player1.playerName + " got 15 bonus points for win streak.");
                GameResults.Add(new GameHistory(game.Player1, game.Player2, true, ratingForGame - winStreakPoins));
            }
            else
            {
                ratingForGame = game.GetRatingForGame(Players.Player1);
                if (ratingForGame < 0)
                {
                    Console.WriteLine("Game " + game.Player1.gamesCount + ". " + "Rating for game must be less then 0");
                    game.Player1.gamesCount--;
                    return;
                }
                GameResults.Add(new GameHistory(game.Player1, game.Player2, true, ratingForGame));
            }
            gamesCount++;
            this.rating += ratingForGame;
            
        }
        //Also, win streak account loses half as many points (premium account privilege)
        public override void LoseGame(Game game)
        {
            gamesCount++;
            winStreak = 0;
            int ratingForGame = game.GetRatingForGame(Players.Player1);
            if (ratingForGame < 0)
            {
                Console.WriteLine("Game " + game.Player1.gamesCount + ". " + "Rating for game must be less then 0");
                game.Player1.gamesCount--;
                return;
            }
            this.rating -= ratingForGame / 2;
            if (this.rating < 0)
                this.rating = 1;
            GameResults.Add(new GameHistory(game.Player1, game.Player2, false, ratingForGame));
        }
    }
}
