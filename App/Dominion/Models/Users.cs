using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominion.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }

        [MaxLength(15, ErrorMessage = "Name can only be 100 characters")]
        public string UserName { get; set; }

        [MaxLength(30, ErrorMessage = "Name can only be 30 characters")]
        public string FirstName { get; set; }

        [MaxLength(30, ErrorMessage = "Name can only be 30 characters")]
        public string LastName { get; set; }

        public int OrgID { get; set; }

        public int AuthLevel { get; set; }
    }
}
