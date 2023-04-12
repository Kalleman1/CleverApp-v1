using CleverAppen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using CleverAppen.Platforms.Android;

namespace CleverAppen.Service
{
    public class ProductService
    {
        List<Product> productList = new();
        HttpClient httpClient;

        public ProductService()
        {
#if DEBUG
            CleverAppen.Platforms.Android.CustomHttpClientHandler customHttpClientHandler = new CustomHttpClientHandler();
            HttpClientHandler insecureHandler = customHttpClientHandler.GetInsecureHandler();
            httpClient = new HttpClient(insecureHandler);
#else
        httpClient = new HttpClient();
#endif
        }

        public async Task<List<Product>> GetProducts()
        {
            if (productList.Count > 0)
            {
                return productList;
            }

            await Task.Run(async () =>
            {
                var response = await httpClient.GetAsync("https://192.168.20.245:5074/Product");

                if (response.IsSuccessStatusCode)
                {
                    productList = await response.Content.ReadFromJsonAsync<List<Product>>();
                }
            });


            return productList;
        }
    }
}
