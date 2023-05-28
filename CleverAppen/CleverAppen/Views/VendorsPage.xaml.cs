using CleverAppen.ViewModels;

namespace CleverAppen.Views;

public partial class VendorsPage : ContentPage
{
	public VendorsPage()
	{
        InitializeComponent();
        BindingContext = new VendorViewModel();
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetBackButtonTitle(this, null);
    }
}