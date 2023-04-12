using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public async Task Login(string email, string password)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://devinvoice.6lgx.com/api/login");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Device-Type", "ios");
            request.Headers.Add("Authorization", "");
            var collection = new List<KeyValuePair<string, string>>();
            collection.Add(new("email", email));
            collection.Add(new("password", password));
            collection.Add(new("timezone", "Asia/Karachi"));
            collection.Add(new("fcm_token", "ABC"));
            var content = new FormUrlEncodedContent(collection);
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());

        }
    }

    
}
