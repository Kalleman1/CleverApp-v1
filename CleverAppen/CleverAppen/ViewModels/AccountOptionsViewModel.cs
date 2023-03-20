using CleverAppen.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.ViewModels
{
    public partial class AccountOptionsViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task GoToAccountSettings()
        {
            await Shell.Current.GoToAsync(nameof(AccountSettingsPage));
        }
    }
}
