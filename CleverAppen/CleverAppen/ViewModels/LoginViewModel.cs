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
using Firebase.Database.Query;

namespace CleverAppen.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string webApiKey = "AIzaSyAlK9GyxNO9Zv7pUZskBNrV0laWWVS-N2g";
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

        public LoginViewModel()
        {
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
                this.UserId = "User1";
                await GetCompaniesForUser(UserId);
                CurrentState = "IsLoggedIn";
                //var appShell = new AppShell();
                //Application.Current.MainPage = appShell;
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
                throw;
            }

        }

        public async Task<List<Company>> GetCompaniesForUser(string userId)
        {
            List<Company> companies = new List<Company>();

            var companiesNode = firebaseClient.Child("Users").Child(userId).Child("Companies");

            var snapshot = await companiesNode.OnceAsync<Company>();

            foreach(var companySnapshot in snapshot)
            {
                Company company = companySnapshot.Object;
                companies.Add(company);
            }

            return companies;
        }
    }
}
