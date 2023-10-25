using LR2;

namespace LR2
{
    public class LR2
    {
        public static void Main(String[] args)
        {
            WinStreakAccount Player_1 = new WinStreakAccount("Sofia");
            PremiumAccount Player_2 = new PremiumAccount("Liza");
            Console.WriteLine(Player_1.playerName + " - WinStreak Account\n" + Player_2.playerName + " - Premium Account");
            //3 basic games
            CreateGame.StartGame(CreateGame.CreateBasicGame(Player_1, Player_2, 10, Victory.Player1));
            CreateGame.StartGame(CreateGame.CreateBasicGame(Player_1, Player_2, 20, Victory.Player1));
            

            CreateGame.StartGame(CreateGame.CreateBasicGame(Player_1, Player_2, 50, Victory.Player1));
            CreateGame.StartGame(CreateGame.CreateBasicGame(Player_1, Player_2, 5, Victory.Player1));
            //training game with out points
            CreateGame.StartGame(CreateGame.CreateTrainingGame(Player_1, Player_2, Victory.Player2));
            CreateGame.StartGame(CreateGame.CreateBasicGame(Player_1, Player_2, 5, Victory.Player2));
            //all-in-game
            CreateGame.StartGame(CreateGame.CreateAllInGame(Player_1, Player_2, Victory.Player1));


            Player_1.GetStats();
            Player_2.GetStatsReverse();
        }
    }
}