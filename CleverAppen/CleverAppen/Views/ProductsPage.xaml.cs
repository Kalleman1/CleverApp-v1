using CleverAppen.ViewModels;

namespace CleverAppen.Views;

public partial class ProductsPage : ContentPage
{
   
	public ProductsPage()
	{
        InitializeComponent();
        BindingContext = new ProductViewModel();
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetBackButtonTitle(this, null);
    }
}