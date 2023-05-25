using CleverAppen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        private Company _selectedCompany;

        public Company SelectedCompany
        {
            get { return _selectedCompany; }
            set
            {
                _selectedCompany = value;
                OnPropertyChanged();
            }
        }

        private List<Product> _products;
        public List<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        private List<Vendor> _vendors;
        public List<Vendor> Vendors
        {
            get { return _vendors; }
            set
            {
                _vendors = value;
                OnPropertyChanged();
            }
        }

        public DashboardViewModel()
        {
            _selectedCompany = App.SelectedCompany;
            _products = App.Products.OrderByDescending(p => p.Total).ToList();
            _vendors = App.Vendors;
        }
    }
}
