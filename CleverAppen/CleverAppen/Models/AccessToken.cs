using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.Models
{
    public class AccessToken
    {
        public int UserId { get; set; }
        public string FcmToken { get; set; }
        public string LoginType { get; set; }
        public string PageType { get; set; }
        public string Token { get; set; }
        public string UserAgent { get; set; }
        public string Timezone { get; set; }
        public int Status { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
    }
}
