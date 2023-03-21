using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Microsoft.Maui.HotReload;
using CleverAppen.Service;
using CleverAppen.ViewModels;
using CleverAppen.Views;
using Syncfusion.Maui.Core.Hosting;
using DevExpress.Maui;

namespace CleverAppen;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.ConfigureSyncfusionCore();
        builder
            .UseMauiApp<App>()
            .UseDevExpress()
            .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();

        builder.Services.AddTransient<AppShell>();
        builder.Services.AddTransient<LoginPage>();

        builder.Services.AddTransient<ProductsPage>();
        builder.Services.AddSingleton<ProductService>();
        builder.Services.AddTransient<ProductViewModel>();

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