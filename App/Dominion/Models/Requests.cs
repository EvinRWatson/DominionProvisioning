using System.ComponentModel.DataAnnotations.Schema;
namespace Dominion.Models
{
    public class Requests
    {
        public int ReqID { get; set; }
        public int UserID { get; set; }
        public int OrgID { get; set; }
        public string ReqDesc { get; set; }
        public string ReqItems { get; set; }
        public string ReqStatus { get; set; }

    }
}
