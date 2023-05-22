using CleverAppen.Models;
using CleverAppen.ViewModels;

namespace CleverAppen.Views;

public partial class DashboardPage : ContentPage
{
    //public Company DashboardCompany { get; set; }
	public DashboardPage()
	{
		InitializeComponent();
        BindingContext = new DashboardViewModel();
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetBackButtonTitle(this, null);
    }

    //protected override void OnAppearing()
    //{
    //    this.DashboardCompany = App.SelectedCompany;
    //}
}