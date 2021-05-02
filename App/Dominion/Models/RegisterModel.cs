using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominion.Models
{
    public class RegisterModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // For ApplicationUser inheriting from IdentityUser
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int OrgID { get; set; }

        public int AuthLevel { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}