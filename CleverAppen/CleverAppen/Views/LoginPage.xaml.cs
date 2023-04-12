using CleverAppen;
using CleverAppen.ViewModels;

namespace CleverAppen.Views;

public partial class LoginPage : ContentPage
{
    private readonly LoginViewModel _viewModel;

    public LoginPage()
	{
		InitializeComponent();

		NavigationPage.SetHasNavigationBar(this, false);
		NavigationPage.SetBackButtonTitle(this, null);

        _viewModel = new LoginViewModel();
		BindingContext = _viewModel;
    }

     private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        bool result = await _viewModel.Login(UsernameTextBox.Text, PasswordTextBox.Text);

        if (result)
        {
            var appShell = new AppShell();
            Application.Current.MainPage = appShell;
        }
        else
        {
            await DisplayAlert("There was an error logging you in.", "The password and/or username you entered was wrong.", "Ok");
        }
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
    }
}