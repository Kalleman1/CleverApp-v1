using CleverAppen.Models;
using CleverAppen.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public ObservableCollection<Product> Products { get; } = new();
        public Command GetProductsCommand { get; }
        ProductService productService;

        public ProductViewModel(ProductService productService)
        {
            this.productService = productService;
            GetProductsCommand = new Command(async () => await GetProductsAsync());
        }

        public async Task GetProductsAsync()
        {
            try
            {
                IsBusy = true;

                if (Products.Count > 0)
                {
                    Products.Clear();
                }

                var products = await productService.GetProducts();

                foreach (var product in products)
                {
                    Products.Add(product);
                }
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
