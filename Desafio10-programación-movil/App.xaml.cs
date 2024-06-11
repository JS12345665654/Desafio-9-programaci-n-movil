using Desafio10_programación_movil.Views;

namespace Desafio10_programación_movil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginView());
        }
    }
}
