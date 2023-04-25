namespace CleverAppen.Views;

public partial class SaleItemsPage : ContentPage
{
	public SaleItemsPage()
	{
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetBackButtonTitle(this, null);
    }
}