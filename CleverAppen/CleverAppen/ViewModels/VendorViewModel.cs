using CleverAppen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.ViewModels
{
    public class VendorViewModel : BaseViewModel
    {
        private List<Vendor> _vmVendors;
        public List<Vendor> Vendors
        {
            get { return _vmVendors; }
            set
            {
                _vmVendors = value;
                OnPropertyChanged();
            }
        }

        public VendorViewModel()
        {
            _vmVendors = App.Vendors;
        }
    }
}
