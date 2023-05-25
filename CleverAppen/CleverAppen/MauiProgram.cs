﻿using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Microsoft.Maui.HotReload;
using CleverAppen.ViewModels;
using CleverAppen.Views;
using DevExpress.Maui;

namespace CleverAppen;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseDevExpress()
            .ConfigureFonts
            (fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();

        builder.Services.AddTransient<AppShell>();
        builder.Services.AddTransient<LoginPage>();

        builder.Services.AddTransient<ProductsPage>();
        builder.Services.AddTransient<ProductViewModel>();

        builder.Services.AddTransient<GroupsTab>();
        builder.Services.AddTransient<CustomProductsTab>();
        builder.Services.AddTransient<SaleItemsPage>();

        builder.Services.AddTransient<AccountOptionsPage>();
        builder.Services.AddTransient<AccountOptionsViewModel>();
        builder.Services.AddTransient<AccountSettingsPage>();
        builder.Services.AddTransient<AccountSettingsViewModel>();
        builder.Services.AddTransient<AddInvoicePage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }

}