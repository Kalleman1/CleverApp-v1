using CleverAppen; 
namespace CleverAppen.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

		NavigationPage.SetHasNavigationBar(this, false);
		NavigationPage.SetBackButtonTitle(this, null); 
	}

    private void LoginButton_Clicked(object sender, EventArgs e)
    {
		if (UsernameTextBox.Text == "123" && PasswordTextBox.Text == "123")
		{
			var appShell = new AppShell();
			Application.Current.MainPage = appShell;
		}
		else
		{
			DisplayAlert("There was an error logging you in.", "The password and/or username you entered was wrong.", "Ok"); 
		}
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
    }
}