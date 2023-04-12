using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverAppen.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Password { get; set; }
        public string VerifiedToken { get; set; }
        public int IsAdmin { get; set; }
        public int IsVerified { get; set; }
        public DateTime? EmailVerifiedAt { get; set; }
        public int Status { get; set; }
        public int IsSignupComplete { get; set; }
        public string SignupLastUrl { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int LanguageId { get; set; }
        public int CurrencyId { get; set; }
        public string EconomicAgreementToken { get; set; }
        public int IsEconomicAgreementToken { get; set; }
        public string StripeCustomerId { get; set; }
        public Dictionary<string, Dictionary<string, string>> Settings { get; set; }
        public DateTime? DeleteOn { get; set; }
        public DateTime? DeactivateOn { get; set; }
        public int IsDeactivated { get; set; }
        public string FromEmails { get; set; }
        public string RememberToken { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public List<Company> Companies { get; set; }
    }
}
