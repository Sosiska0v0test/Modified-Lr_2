using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class CreateGame
    {

        public static Game CreateBasicGame(BasicAccount player1, BasicAccount player2, int ratingForGame, Victory winner)
        {
            return new BasicGame(player1, player2, ratingForGame, winner);
        }

        public static Game CreateTrainingGame(BasicAccount player1, BasicAccount player2, Victory winner)
        {
            return new TrainingGame(player1, player2, winner);
        }

        public static Game CreateAllInGame(BasicAccount player1, BasicAccount player2, Victory winner)
        {
            //winner will get all points, looser will have only 1 point
            return new AllInGame(player1, player2, player1.rating + player2.rating, winner);
        }

        public static int gamesCount = 1;
        public static void StartGame(Game game)
        {
            if (game.Winner == Victory.Player1)
            {
                Console.WriteLine("Game " + gamesCount + ". " + game.Player1.playerName + " won game against " + game.Player2.playerName);
                game.Player1.WinGame(game);
                game.Player2.LoseGame(game);
            }
            else
            {
                Console.WriteLine("Game " + gamesCount + ". " + game.Player2.playerName + " won game against " + game.Player1.playerName);
                game.Player2.WinGame(game);
                game.Player1.LoseGame(game);
            }
            gamesCount ++;
        }
    }
}
