using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominion.Models
{
    public class StockList
    {
        [Key]
        public int StockID { get; set; }

        [MaxLength(100, ErrorMessage = "Name can only be 100 characters")]
        public string ItemName { get; set; }

        [MaxLength(500, ErrorMessage = "Image Path can only be 500 characters")]
        public string ImagePath { get; set; }

        public int OrgID { get; set; }
    }
}
