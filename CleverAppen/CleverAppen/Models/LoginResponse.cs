using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.Models
{
    public class LoginResponse
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public User Result { get; set; }
    }
}
