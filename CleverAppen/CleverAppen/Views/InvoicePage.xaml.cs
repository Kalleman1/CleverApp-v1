namespace CleverAppen.Views;

public partial class InvoicePage : ContentPage
{
	public InvoicePage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetBackButtonTitle(this, null);
    }
}