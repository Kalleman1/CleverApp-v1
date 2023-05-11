using CleverAppen;
using CleverAppen.ViewModels;

namespace CleverAppen.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

		BindingContext = new LoginViewModel(Navigation);

		NavigationPage.SetHasNavigationBar(this, false);
		NavigationPage.SetBackButtonTitle(this, null);
	}


}