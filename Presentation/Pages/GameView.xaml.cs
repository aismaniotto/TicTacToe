using TicTacToe.ViewModel;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

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
