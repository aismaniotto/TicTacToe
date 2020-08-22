using System.Collections.Generic;
using System.Linq;

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
                return CheckCurrentStatus(currentPlayer);
            }

            return CheckCurrentStatus();    
        }

        public Status CheckCurrentStatus(Player currentPlayer = Player.None)
        { 
            var gameTiles = GameStore.GetAllTiles();
            if (gameTiles.Count(player => player != Player.None) < 5)
                return Status.InProgress;

            if (currentPlayer == Player.None)
                currentPlayer = GameStore.GetCurrentPlayer();

            var tilesFromCurrentPlayer = new List<int>();

            gameTiles.ForEach((player) =>
            {
                if (player == currentPlayer)
                    tilesFromCurrentPlayer.Add((int)player);
                else
                    tilesFromCurrentPlayer.Add((int)Player.None);
            });

            tilesFromCurrentPlayer[0] *= (int)Tile.Tile0x0;
            tilesFromCurrentPlayer[1] *= (int)Tile.Tile0x1;
            tilesFromCurrentPlayer[2] *= (int)Tile.Tile0x2;
            tilesFromCurrentPlayer[3] *= (int)Tile.Tile1x0;
            tilesFromCurrentPlayer[4] *= (int)Tile.Tile1x1;
            tilesFromCurrentPlayer[5] *= (int)Tile.Tile1x2;
            tilesFromCurrentPlayer[6] *= (int)Tile.Tile2x0;
            tilesFromCurrentPlayer[7] *= (int)Tile.Tile2x1;
            tilesFromCurrentPlayer[8] *= (int)Tile.Tile2x2;

            var winningSum = GameStore.WinningSum * (int)currentPlayer;

            if (tilesFromCurrentPlayer[0] + tilesFromCurrentPlayer[1] + tilesFromCurrentPlayer[2] == winningSum)
            {
                return currentPlayer == Player.O ? Status.PlayerOWin : Status.PlayerXWin;
            }
            else if (tilesFromCurrentPlayer[3] + tilesFromCurrentPlayer[4] + tilesFromCurrentPlayer[5] == winningSum)
            {
                return currentPlayer == Player.O ? Status.PlayerOWin : Status.PlayerXWin;
            }
            else if (tilesFromCurrentPlayer[6] + tilesFromCurrentPlayer[7] + tilesFromCurrentPlayer[8] == winningSum)
            {
                return currentPlayer == Player.O ? Status.PlayerOWin : Status.PlayerXWin;
            }
            else if (tilesFromCurrentPlayer[0] + tilesFromCurrentPlayer[3] + tilesFromCurrentPlayer[6] == winningSum)
            {
                return currentPlayer == Player.O ? Status.PlayerOWin : Status.PlayerXWin;
            }
            else if (tilesFromCurrentPlayer[1] + tilesFromCurrentPlayer[4] + tilesFromCurrentPlayer[7] == winningSum)
            {
                return currentPlayer == Player.O ? Status.PlayerOWin : Status.PlayerXWin;
            }
            else if (tilesFromCurrentPlayer[2] + tilesFromCurrentPlayer[5] + tilesFromCurrentPlayer[8] == winningSum)
            {
                return currentPlayer == Player.O ? Status.PlayerOWin : Status.PlayerXWin;
            }
            else if (tilesFromCurrentPlayer[0] + tilesFromCurrentPlayer[4] + tilesFromCurrentPlayer[8] == winningSum)
            {
                return currentPlayer == Player.O ? Status.PlayerOWin : Status.PlayerXWin;
            }
            else if (tilesFromCurrentPlayer[2] + tilesFromCurrentPlayer[4] + tilesFromCurrentPlayer[6] == winningSum)
            {
                return currentPlayer == Player.O ? Status.PlayerOWin : Status.PlayerXWin;
            }

            if (gameTiles.Count(player => player == Player.None) == 0)
                return Status.ItsATie;

            return Status.InProgress;
        }

        public void ResetScore()
        {
            GameStore.SetScoreO(0);
            GameStore.SetScoreX(0);
        }
    }
}
