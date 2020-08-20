using TicTacToe.ViewModel;
using Xamarin.Forms;

namespace TicTacToe.Presentation.Pages
{
    public partial class GameView : ContentPage
    {
        public GameView()
        {
            InitializeComponent();
            BindingContext = new GameViewModel();
        }
    }
}
