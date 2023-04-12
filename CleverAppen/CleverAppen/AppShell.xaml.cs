using CleverAppen.Views;
using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm;

namespace CleverAppen;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
        Routing.RegisterRoute(nameof(InvoicePage), typeof(InvoicePage));
        Routing.RegisterRoute(nameof(VendorsPage), typeof(VendorsPage));
        Routing.RegisterRoute(nameof(ProductsPage), typeof(ProductsPage));
        Routing.RegisterRoute(nameof(SaleItemsPage), typeof(SaleItemsPage));
        Routing.RegisterRoute(nameof(GroupsTab), typeof(GroupsTab));
        Routing.RegisterRoute(nameof(CustomProductsTab), typeof(CustomProductsTab));
        Routing.RegisterRoute(nameof(AccountOptionsPage), typeof(AccountOptionsPage));

        int pageCount = Navigation.NavigationStack.Count;
    }
    
}
