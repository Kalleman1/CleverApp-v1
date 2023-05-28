using CleverAppen.Views;
using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm;
using System.Windows.Input;

namespace CleverAppen;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(SaleItemsPage), typeof(SaleItemsPage));
        Routing.RegisterRoute(nameof(ProductsPage), typeof(ProductsPage));
        Routing.RegisterRoute(nameof(VendorsPage), typeof(VendorsPage));
        Routing.RegisterRoute(nameof(InvoicePage), typeof(InvoicePage));
        Routing.RegisterRoute(nameof(AccountSettingsPage), typeof(AccountSettingsPage));
        Routing.RegisterRoute(nameof(TakePicture), typeof(TakePicture));

        BindingContext= this;


    }
    public ICommand AccountCommand => new Command(async () => await NavigatedToAccountSettings());
    public ICommand ProductsCommand => new Command(async () => await NavigatedToProducts());
    public ICommand InvoicesCommand => new Command(async () => await NavigatedToInvoices());
    public ICommand VendorsCommand => new Command(async () => await NavigatedToVendors());
    public ICommand SaleItemsCommand => new Command(async () => await NavigatedToSaleItems());

    async Task NavigatedToAccountSettings()
    {
        await Shell.Current.GoToAsync(nameof(AccountSettingsPage));
        Shell.Current.FlyoutIsPresented= false;
    }

    async Task NavigatedToProducts()
    {
        await Shell.Current.GoToAsync(nameof(ProductsPage));
        Shell.Current.FlyoutIsPresented = false;
    }
     async Task NavigatedToInvoices()
    {
        await Shell.Current.GoToAsync(nameof(InvoicePage));
        Shell.Current.FlyoutIsPresented = false;
    }
    async Task NavigatedToVendors()
    {
        await Shell.Current.GoToAsync(nameof(VendorsPage));
        Shell.Current.FlyoutIsPresented = false;
    }
    async Task NavigatedToSaleItems()
    {
        await Shell.Current.GoToAsync("SaleItemsPage");
        Shell.Current.FlyoutIsPresented = false;
    }
}
