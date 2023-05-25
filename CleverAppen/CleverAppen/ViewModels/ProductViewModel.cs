using CleverAppen.Models;
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
        private List<Product> _vmProducts;
        public List<Product> Products
        {
            get { return _vmProducts; }
            set
            {
                _vmProducts = value;
                OnPropertyChanged();
            }
        }

        public ProductViewModel()
        {
            _vmProducts = App.Products;
        }
    }
}
