using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Dominion.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int OrgID { get; set; }

        public int AuthLevel { get; set; }
    }
}
