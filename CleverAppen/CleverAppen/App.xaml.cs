using CleverAppen.Models;
using CleverAppen.Views;
using System.Security.Cryptography.X509Certificates;

namespace CleverAppen;

public partial class App : Application
{
	public static Company SelectedCompany { get; set; }
	public static List<Product> Products { get; set; }
	public static List<Vendor> Vendors { get; set; }
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new LoginPage());

    }
}
