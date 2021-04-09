using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominion.Models
{
    public class Requests
    {
        [Key]
        public int ReqID { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }

        public int OrgID { get; set; }
        [ForeignKey("StockID")]
        public int StockID { get; set; }

        [MaxLength(100, ErrorMessage = "Description can only be 100 characters")]
        public string ReqDesc { get; set; }

        [MaxLength(500, ErrorMessage = "Items can only be 500 characters")]
        public string ReqItems { get; set; }

        [MaxLength(100, ErrorMessage = "Status can only be 100 characters")]
        public string ReqStatus { get; set; }


    }
}
