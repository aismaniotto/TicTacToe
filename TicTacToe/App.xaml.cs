using TicTacToe.Presentation.Pages;
using Xamarin.Forms;

namespace TicTacToe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GameView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
