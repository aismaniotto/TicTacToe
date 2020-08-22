using System.Windows.Input;
using TicTacToe.Game;
using Xamarin.Forms;

namespace TicTacToe.ViewModel
{
    public class GameViewModel : BaseViewModel
    {
        public ICommand PlayCommand { get; set; }
        public ICommand ResetCommand { get; set; }

        public GameStore GameStore { get; set; }
        public GamePlay GamePlay { get; set; }

        private bool _isPlaying;
        public bool IsPlaying
        {
            get { return _isPlaying; }
            set { SetProperty(ref _isPlaying, value); }
        }

        public Player CurrentPlayer
        {
            get { return GameStore.GetCurrentPlayer(); }
            set
            {
                GameStore.SetCurrentPlayer(value);
                OnPropertyChanged();
            }
        }

        public int ScoreX
        {
            get { return GameStore.GetScoreX(); }
            set
            {
                GameStore.SetScoreX(value);
                OnPropertyChanged();
            }
        }

        public int ScoreO
        {
            get { return GameStore.GetScoreO(); }
            set
            {
                GameStore.SetScoreO(value);
                OnPropertyChanged();
            }
        }

        public Player Tile0x0
        {
            get { return GameStore.GetTile(Tile.Tile0x0); }
            set
            {
                GameStore.SetTile(Tile.Tile0x0, value);
                OnPropertyChanged();
            }
        }

        public Player Tile0x1
        {
            get { return GameStore.GetTile(Tile.Tile0x1); }
            set
            {
                GameStore.SetTile(Tile.Tile0x1, value);
                OnPropertyChanged();
            }
        }

        public Player Tile0x2
        {
            get { return GameStore.GetTile(Tile.Tile0x2); }
            set
            {
                GameStore.SetTile(Tile.Tile0x2, value);
                OnPropertyChanged();
            }
        }

        public Player Tile1x0
        {
            get { return GameStore.GetTile(Tile.Tile1x0); }
            set
            {
                GameStore.SetTile(Tile.Tile1x0, value);
                OnPropertyChanged();
            }
        }

        public Player Tile1x1
        {
            get { return GameStore.GetTile(Tile.Tile1x1); }
            set
            {
                GameStore.SetTile(Tile.Tile1x1, value);
                OnPropertyChanged();
            }
        }

        public Player Tile1x2
        {
            get { return GameStore.GetTile(Tile.Tile1x2); }
            set
            {
                GameStore.SetTile(Tile.Tile1x2, value);
                OnPropertyChanged();
            }
        }

        public Player Tile2x0
        {
            get { return GameStore.GetTile(Tile.Tile2x0); }
            set
            {
                GameStore.SetTile(Tile.Tile2x0, value);
                OnPropertyChanged();
            }
        }

        public Player Tile2x1
        {
            get { return GameStore.GetTile(Tile.Tile2x1); }
            set
            {
                GameStore.SetTile(Tile.Tile2x1, value);
                OnPropertyChanged();
            }
        }

        public Player Tile2x2
        {
            get { return GameStore.GetTile(Tile.Tile2x2); }
            set
            {
                GameStore.SetTile(Tile.Tile2x2, value);
                OnPropertyChanged();
            }
        }


        public GameViewModel()
        {
            GameStore = new GameStore();
            GamePlay = new GamePlay();
            PlayCommand = new Command<Tile>(PlayCommandAction);
            ResetCommand = new Command(ResetCommandAction);
        }

        private void PlayCommandAction(Tile tile)
        {
            if (IsPlaying) return;
            IsPlaying = true;

            var gameStatus = GamePlay.PlayHere(tile);
            // Necessary notify because the attribution isn't done by the setter
            NotifyTile(tile);

            IsPlaying = false;
        }

        private void NotifyTile(Tile tile)
        {
            switch (tile)
            {
                case Tile.Tile0x0:
                    OnPropertyChanged(nameof(Tile0x0));
                    break;
                case Tile.Tile0x1:
                    OnPropertyChanged(nameof(Tile0x1));
                    break;
                case Tile.Tile0x2:
                    OnPropertyChanged(nameof(Tile0x2));
                    break;
                case Tile.Tile1x0:
                    OnPropertyChanged(nameof(Tile1x0));
                    break;
                case Tile.Tile1x1:
                    OnPropertyChanged(nameof(Tile1x1));
                    break;
                case Tile.Tile1x2:
                    OnPropertyChanged(nameof(Tile1x2));
                    break;
                case Tile.Tile2x0:
                    OnPropertyChanged(nameof(Tile2x0));
                    break;
                case Tile.Tile2x1:
                    OnPropertyChanged(nameof(Tile2x1));
                    break;
                case Tile.Tile2x2:
                    OnPropertyChanged(nameof(Tile2x2));
                    break;
            }
        }

        private void ResetCommandAction()
        {
            GamePlay.ResetScore();
            ClearAllTiles();
        }

        private void ClearAllTiles()
        {
            Tile0x0 = Player.None;
            Tile0x1 = Player.None;
            Tile0x2 = Player.None;
            Tile1x0 = Player.None;
            Tile1x1 = Player.None;
            Tile1x2 = Player.None;
            Tile2x1 = Player.None;
            Tile2x2 = Player.None;
            Tile2x0 = Player.None;
        }
    }
}
