﻿using CleverAppen.Views;
using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm;

namespace CleverAppen;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(AccountOptionsPage), typeof(AccountOptionsPage));
        Routing.RegisterRoute(nameof(AccountSettingsPage), typeof(AccountSettingsPage));
        Routing.RegisterRoute(nameof(AddInvoicePage), typeof(AddInvoicePage));

        int pageCount = Navigation.NavigationStack.Count;
    }

    private async void AccountImageButtons_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AccountOptionsPage));
    }

    private async void AddPictureImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddInvoicePage));
    }
}
