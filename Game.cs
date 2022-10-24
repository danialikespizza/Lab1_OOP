using System;
namespace Lab1_OOP
{
    public class Game
    {
        private static int gameSeed = 1234567890;

        GameAccount firstPlayer;
        GameAccount secondPlayer;
        int gameID;
        int rating;
        GameAccount? winner = null;

        public int Rating
        {
            get { return rating; }
        }
        public GameAccount FirstPlayer
        {
            get { return firstPlayer; }
        }
        public GameAccount SecondPlayer
        {
            get { return secondPlayer; }
        }
        public GameAccount Winner
        {
            get { return winner; }
        }
        public int GameID
        {
            get { return gameID; }
        }

       public Game(GameAccount firstPlayer, GameAccount secondPlayer, int rating)
        {
            gameID = gameSeed++;
            this.firstPlayer = firstPlayer;
            this.secondPlayer = secondPlayer;
            if (rating < 0)
            {
                throw new ArgumentOutOfRangeException("Rating must be positive, you have entered" + rating);
            }
            else
            {
                this.rating = rating;
            }
            
        }
        public void Result(Game game)
        {
            Random rd = new Random();
            if (Convert.ToInt32(rd.Next(1, 100)) > 50)
            {
                game.winner = secondPlayer;
                game.secondPlayer.WinGame(game);
                game.firstPlayer.LoseGame(game);
            }
            else
            {
                game.winner = firstPlayer;
                game.firstPlayer.WinGame(game);
                game.secondPlayer.LoseGame(game);
            }
        }
    }
}

