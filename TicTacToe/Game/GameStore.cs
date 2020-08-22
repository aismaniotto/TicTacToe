using Xamarin.Essentials;

namespace TicTacToe.Game
{
    public class GameStore
    {
        const string CurrentPlayer = "CurrentPlayerKey";
        const string ScoreX = "ScoreXKey";
        const string ScoreO = "ScoreOKey";
        const string Tile0x0 = "Tile0x0Key";
        const string Tile0x1 = "Tile0x1Key";
        const string Tile0x2 = "Tile0x2Key";
        const string Tile1x0 = "Tile1x0Key";
        const string Tile1x1 = "Tile1x1Key";
        const string Tile1x2 = "Tile1x2Key";
        const string Tile2x0 = "Tile2x0Key";
        const string Tile2x1 = "Tile2x1Key";
        const string Tile2x2 = "Tile2x2Key";
        const int WinnerSumwinning = 15;

        public Player GetCurrentPlayer()
        {
            return (Player)Preferences.Get(CurrentPlayer, (int)Player.X);
        }
          
        public void SetCurrentPlayer(Player player)
        {
            Preferences.Set(CurrentPlayer, (int)player);
        }

        public int GetScoreX()
        {
            return Preferences.Get(ScoreX, 0);
        }
        public void SetScoreX(int score)
        {
            Preferences.Set(ScoreX, score);
        }

        public int GetScoreO()
        {
            return Preferences.Get(ScoreO, 0);
        }
        public void SetScoreO(int score)
        {
            Preferences.Set(ScoreO, score);
        }


        public Player GetTile(Tile tile)
        {
            switch(tile){
                case Tile.Tile0x0:
                    return (Player)Preferences.Get(Tile0x0, 0);
                case Tile.Tile0x1:
                    return (Player)Preferences.Get(Tile0x1, 0);
                case Tile.Tile0x2: 
                    return (Player)Preferences.Get(Tile0x2, 0);
                case Tile.Tile1x0:
                    return (Player)Preferences.Get(Tile1x0, 0);
                case Tile.Tile1x1:
                    return (Player)Preferences.Get(Tile1x1, 0);
                case Tile.Tile1x2:
                    return (Player)Preferences.Get(Tile1x2, 0);
                case Tile.Tile2x0:
                    return (Player)Preferences.Get(Tile2x0, 0);
                case Tile.Tile2x1:
                    return (Player)Preferences.Get(Tile2x1, 0);
                case Tile.Tile2x2:
                    return (Player)Preferences.Get(Tile2x2, 0);
               
                default:
                    return 0;
            }
        }
        public void SetTile(Tile tile, Player currentPlayer)
        {
            switch (tile)
            {
                case Tile.Tile0x0:
                    Preferences.Set(Tile0x0, (int)currentPlayer);
                    break;
                case Tile.Tile0x1:
                    Preferences.Set(Tile0x1, (int)currentPlayer);
                    break;
                case Tile.Tile0x2:
                    Preferences.Set(Tile0x2, (int)currentPlayer);
                    break;
                case Tile.Tile1x0:
                    Preferences.Set(Tile1x0, (int)currentPlayer);
                    break;
                case Tile.Tile1x1:
                    Preferences.Set(Tile1x1, (int)currentPlayer);
                    break;
                case Tile.Tile1x2:
                    Preferences.Set(Tile1x2, (int)currentPlayer);
                    break;
                case Tile.Tile2x0:
                    Preferences.Set(Tile2x0, (int)currentPlayer);
                    break;
                case Tile.Tile2x1:
                    Preferences.Set(Tile2x1, (int)currentPlayer);
                    break;
                case Tile.Tile2x2:
                    Preferences.Set(Tile2x2, (int)currentPlayer);
                    break;
            }
        }

    }
}
