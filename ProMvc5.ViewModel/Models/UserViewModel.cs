using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ProMvc5.ViewModel.Models;

namespace ProMvc5.ViewModel.Models
{
    public class UserViewModel
    {     
        public int AccessFailedCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public int MyProperty { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public ICollection<Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin> Logins { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public ICollection<Microsoft.AspNet.Identity.EntityFramework.IdentityRole> Roles { get; set; }
        public string SecurityStamp { get; set; }
        public string UserName { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public ICollection<Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim> Claims { get; set; }

    }
}