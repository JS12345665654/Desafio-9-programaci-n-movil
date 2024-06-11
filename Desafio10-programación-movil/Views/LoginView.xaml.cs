namespace Desafio10_programación_movil.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private async void btn_CreateAccount_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new CreateAccountView());
    }
}