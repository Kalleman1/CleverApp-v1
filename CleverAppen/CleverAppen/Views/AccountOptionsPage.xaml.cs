using CleverAppen.ViewModels;
using CommunityToolkit.Mvvm.Input;

namespace CleverAppen.Views;

public partial class AccountOptionsPage : ContentPage
{
	public AccountOptionsPage(AccountOptionsViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;

        NavigationPage.SetHasNavigationBar(this, false);
		Shell.SetTabBarIsVisible(this, false);
		Shell.SetNavBarIsVisible(this, false);
    }
}