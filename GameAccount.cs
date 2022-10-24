using System;
using System.Linq.Expressions;

namespace Lab1_OOP
{
    public class GameAccount
    {
        private List<Game> allGames = new List<Game>();
        string userName;
        int currentRating;
        int gamesCount;


        public GameAccount(string name)
        {
            userName = name;
            currentRating = 1;
            gamesCount = 0;
        }

        public void WinGame(Game game)
        {
            allGames.Add(game);
            gamesCount += 1;
            currentRating += game.Rating;
        }

        public void LoseGame(Game game)
        {
            allGames.Add(game);
            gamesCount += 1;
            if ((currentRating - game.Rating) > 1)
            {
                currentRating -= game.Rating;
            }
        }

        public void GetStats()
        {
            var stat = new System.Text.StringBuilder();
            stat.AppendLine(userName + "Played in total " + gamesCount + " games " + " and has " + currentRating + " points ");

            
            foreach (var game in allGames)
            {
                string name = (userName == game.FirstPlayer.userName) ? name = game.SecondPlayer.userName: name = game.FirstPlayer.userName;
                string res = (game.Winner == this) ? "won" : "lost";
                stat.AppendLine($"{userName} played against {name} and {res} {game.Rating} rating points in game with index {game.GameID}");

            }
            Console.WriteLine(stat.ToString());
        }
    }
}
