using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int ThisMonthInvoices { get; set; }
        public int YearlyInvoices { get; set; }
    }
}
