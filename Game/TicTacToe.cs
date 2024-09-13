namespace TicTacToe.Game
{
    public enum Player
    {
        X = 1,
        O = -1,
        None = 0,
    }

    public enum Tile
    {
        Tile0x0 = 2,
        Tile0x1 = 7,
        Tile0x2 = 6,
        Tile1x0 = 9,
        Tile1x1 = 5,
        Tile1x2 = 1,
        Tile2x0 = 4,
        Tile2x1 = 3,
        Tile2x2 = 8,
    }

    public enum Status
    {
        PlayerOWin,
        PlayerXWin,
        ItsATie,
        InProgress,
    }
}
