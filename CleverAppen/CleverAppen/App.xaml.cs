using CleverAppen.Views;
using System.Security.Cryptography.X509Certificates;

namespace CleverAppen;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new LoginPage());

    }
}
