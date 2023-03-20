using CleverAppen.ViewModels;
using CommunityToolkit.Maui.Views;

namespace CleverAppen.Views;

public partial class AccountSettingsPage : ContentPage
{

	public AccountSettingsPage(AccountSettingsViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
        NavigationPage.SetHasNavigationBar(this, false);
        Shell.SetTabBarIsVisible(this, false);
        Shell.SetNavBarIsVisible(this, false);
    }

    private async void CancelButton_Clicked(object sender, EventArgs e)
    {
        if (Navigation.NavigationStack.Count > 0)
        {
            await Navigation.PopAsync();
        }
    }
}