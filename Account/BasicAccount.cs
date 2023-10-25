using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class BasicAccount
    {
        const int startRating = 100;
        public string playerName { get; }
        public int rating { get; set; }
        public int gamesCount = 0;
        
        public BasicAccount(string playerName)
        {
            this.playerName = playerName;
            this.rating = startRating;
        }

        public List<GameHistory> GameResults = new List<GameHistory>();


        public virtual void WinGame(Game game)
        {
            gamesCount++;
            int ratingForGame = game.GetRatingForGame(Players.Player1);
            if (ratingForGame < 0)
            {
                Console.WriteLine("Game " + game.Player1.gamesCount + ". " + "Rating for game must be less then 0");
                game.Player1.gamesCount--;
                return;
            }
            this.rating += ratingForGame;
            GameResults.Add(new GameHistory(game.Player1, game.Player2, true, ratingForGame));
            
        }

        public virtual void LoseGame(Game game)
        {
            gamesCount++;
            int ratingForGame = game.GetRatingForGame(Players.Player1);
            if (ratingForGame < 0)
            {
                Console.WriteLine("Game " + game.Player1.gamesCount + ". " + "Rating for game must be less then 0");
                game.Player1.gamesCount--;
                return;
            }
            this.rating -= ratingForGame;
            if (this.rating < 0)
                rating = 1;
            GameResults.Add(new GameHistory(game.Player1, game.Player2, false, ratingForGame));
        }

        public virtual void GetStats()
        {
            Console.WriteLine("\n" + playerName + "'s current score:\t" + rating);
            Console.WriteLine("Game history of " + playerName + ": ");
            foreach (GameHistory PlayerHistory in GameResults)
            {
                PlayerHistory.ShowPlayerHistory();
            }
        }
        public virtual void GetStatsReverse()
        {
            Console.WriteLine("\n" + playerName + "'s current score:\t" + rating);
            Console.WriteLine("Game history of " + playerName + ": ");
            foreach (GameHistory PlayerHistory in GameResults)
            {
                PlayerHistory.ShowPlayerHistoryReverse();
            }
        }

    }
}
