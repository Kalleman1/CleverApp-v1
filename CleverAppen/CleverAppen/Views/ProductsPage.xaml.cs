using CleverAppen.Service;
using CleverAppen.ViewModels;

namespace CleverAppen.Views;

public partial class ProductsPage : ContentPage
{
   
	public ProductsPage(ProductViewModel productViewModel)
	{

        InitializeComponent();

        BindingContext = productViewModel;
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetBackButtonTitle(this, null);
        productViewModel.GetProductsCommand.Execute(this);
    }
}