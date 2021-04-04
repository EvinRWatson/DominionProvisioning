using System.ComponentModel.DataAnnotations.Schema;
namespace Dominion.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organization { get; set; }
        public int OrgID { get; set; }
        public int AuthLevel { get; set; }
    }
}
