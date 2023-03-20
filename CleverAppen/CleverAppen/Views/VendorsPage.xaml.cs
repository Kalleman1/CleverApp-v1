namespace CleverAppen.Views;

public partial class VendorsPage : ContentPage
{
	public VendorsPage()
	{
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetBackButtonTitle(this, null);
    }
}