using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class PremiumAccount : BasicAccount
    {
        public PremiumAccount(string playerName) : base(playerName) { }
        //premium account loses half as many points

        public override void LoseGame(Game game)
        {
            gamesCount++;
            int ratingForGame = game.GetRatingForGame(Players.Player1);
            if (ratingForGame < 0)
            {
                Console.WriteLine("Game " + game.Player1.gamesCount + ". " + "Rating for game must be less then 0");
                game.Player1.gamesCount--;
                return;
            }
            this.rating -= ratingForGame / 2;
            if(this.rating < 0)
                this.rating = 1;
            GameResults.Add(new GameHistory(game.Player1, game.Player2, false, ratingForGame));
        }
    }
}
