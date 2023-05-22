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

        public DashboardViewModel()
        {
            SelectedCompany = App.SelectedCompany;
        }
    }
}
