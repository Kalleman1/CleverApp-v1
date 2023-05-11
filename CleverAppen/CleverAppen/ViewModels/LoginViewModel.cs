using Firebase.Auth;
using Firebase.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleverAppen.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Maui.Layouts;

namespace CleverAppen.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        public string webApiKey = "AIzaSyAlK9GyxNO9Zv7pUZskBNrV0laWWVS-N2g";
        public INavigation _navigation;
        private string userName;
        private string userPassword;
        private string userId;
        FirebaseClient firebaseClient = new FirebaseClient("https://cleverboi-ffba2-default-rtdb.europe-west1.firebasedatabase.app/");

        private string _state = "IsNotLoggedIn";
        public string CurrentState
        {
            get => _state;
            set
            {
                _state = value;
                OnPropertyChanged();
            }
        }

        public Command LoginBtn { get; }

        public string UserId
        {
            get => userId;
            set
            {
                userId = value;
                RaisePropertyChanged("UserId");
            }
        }

        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                RaisePropertyChanged("UserName");
            }
        }

        public string UserPassword
        {
            get => userPassword;
            set
            {
                userPassword = value;
                RaisePropertyChanged("UserPassword");
            }
        }

        public LoginViewModel(INavigation navigation)
        {
            this._navigation = navigation;
            LoginBtn = new Command(LoginBtnTappedAsync);
        }

        private async void LoginBtnTappedAsync(object obj)
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
            try
            {
                //Login with username and password
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(UserName, UserPassword);

                var content = await auth.GetFreshAuthAsync();
                var serializedContent = JsonConvert.SerializeObject(content);
                var userId = auth.User.LocalId;
                Preferences.Set("FreshFirebaseToken", serializedContent);
                this.UserId = userId;
                CurrentState = "IsLoggedIn";
                //await this._navigation.PushAsync(new AppShell());
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
                throw;
            }

        }
    }
}
