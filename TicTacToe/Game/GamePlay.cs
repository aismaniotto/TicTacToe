using System;
namespace TicTacToe.Game
{
    public class GamePlay
    {
        public GameStore GameStore { get; private set; }

        public GamePlay()
        {
            GameStore = new GameStore();
        }

        public bool CanPlayHere(Tile tile)
        {
            return GameStore.GetTile(tile) == Player.None; 
        }
 
        public Status PlayHere(Tile tile)
        {
            if (CanPlayHere(tile))
            {
                var currentPlayer = GameStore.GetCurrentPlayer();
                GameStore.SetTile(tile, currentPlayer);
                GameStore.SetCurrentPlayer(currentPlayer == Player.X ? Player.O : Player.X);
            }

            return CheckCurrentStatus();
        }

        public Status CheckCurrentStatus()
        {
            return Status.OnProgress;
        }

        public void ResetScore()
        {
            GameStore.SetScoreO(0);
            GameStore.SetScoreX(0);
        }
    }
}
