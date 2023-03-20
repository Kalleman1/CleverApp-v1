using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.ViewModels
{
    public partial class AccountSettingsViewModel : ObservableObject
    {
        [RelayCommand]
        async Task Goback()
        {
            await Shell.Current.GoToAsync(".."); 
        }
    }
}
