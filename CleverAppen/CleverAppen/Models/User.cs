using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public Dictionary<string, Company> Companies { get; set; }
    }
}
