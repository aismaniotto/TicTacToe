using System.Windows.Input;

namespace TicTacToe.ViewModel
{
    public class GameViewModel : BaseViewModel
    {
        public ICommand PlayCommand { get; set; }
        public ICommand ResetCommand { get; set; }

        private bool _isPlaying;
        public bool IsPlaying
        {
            get { return _isPlaying; }
            set { SetProperty(ref _isPlaying, value); }
        }

        public GameViewModel()
        {
        }

        private async void PlayCommandAction(int position)
        {
            if (IsPlaying) return;
            IsPlaying = true;

            //do the play here

            // check if someone win

            // check if all is full
            //// if so, it's a tie

            IsPlaying = false;
        }
    }
}
