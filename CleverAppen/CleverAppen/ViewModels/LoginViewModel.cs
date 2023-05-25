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
using CleverAppen.Views;

namespace CleverAppen.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string webApiKey = "AIzaSyAlK9GyxNO9Zv7pUZskBNrV0laWWVS-N2g";
        public List<Company> Companies { get; set; }
        FirebaseClient firebaseClient = new FirebaseClient("https://cleverboi-ffba2-default-rtdb.europe-west1.firebasedatabase.app/");
        public Command LoginBtn { get; }
        public Command ChooseCompanyBtn { get; }

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


        private string _userId;
        public string UserId
        {
            get => _userId;
            set
            {
                _userId = value;
                RaisePropertyChanged("UserId");
            }
        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                RaisePropertyChanged("UserName");
            }
        }

        private string _userPassword;
        public string UserPassword
        {
            get => _userPassword;
            set
            {
                _userPassword = value;
                RaisePropertyChanged("UserPassword");
            }
        }

        public LoginViewModel()
        {
            LoginBtn = new Command(LoginBtnTappedAsync);
            ChooseCompanyBtn = new Command(ChooseCompanyBtnTappedAsync);
        }

        private async void LoginBtnTappedAsync(object obj)
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
            try
            {
                //Login with username and password using firebase
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(UserName, UserPassword);

                var content = await auth.GetFreshAuthAsync();
                var serializedContent = JsonConvert.SerializeObject(content);
                var userId = auth.User.LocalId;
                Preferences.Set("FreshFirebaseToken", serializedContent);
                this._userId = userId;
                await GetCompaniesForUser(UserId);
                CurrentState = "IsLoggedIn";
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
                throw;
            }

        }

        public async void ChooseCompanyBtnTappedAsync(object selectedCompany)
        {
            App.SelectedCompany = (Company)selectedCompany;
            await GetProductsForCompany(UserId, App.SelectedCompany.Name);
            await GetVendorsForCompany(UserId, App.SelectedCompany.Name);

            var appShell = new AppShell();
            Application.Current.MainPage = appShell;

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
            Companies = companies;
            return companies;
        }

        public async Task<List<Product>> GetProductsForCompany(string userId, string companyName)
        {
            List<Product> products = new List<Product>();

            var productsNode = firebaseClient.Child("Users").Child(userId).Child("Companies").Child(companyName).Child("Products");

            var snapshot = await productsNode.OnceAsync<Product>();

            foreach(var productSnapshot in snapshot)
            {
                Product product = productSnapshot.Object;
                products.Add(product);
            }
            App.Products = products;
            return products;
        }

        public async Task<List<Vendor>> GetVendorsForCompany (string userId, string companyName)
        {
            List<Vendor> vendors = new List<Vendor>();

            var vendorsNode = firebaseClient.Child("Users").Child(userId).Child("Companies").Child(companyName).Child("Vendors");

            var snapshot = await vendorsNode.OnceAsync<Vendor>();

            foreach(var vendorSnapshot in snapshot)
            {
                Vendor vendor = vendorSnapshot.Object;
                vendors.Add(vendor);
            }
            App.Vendors = vendors;
            return vendors;
        }
    }
}
