using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominion.Models
{
    public class Inventory
    {
        [Key]
        public int StockID { get; set; }

        [MaxLength(100, ErrorMessage = "Name can only be 100 characters")]
        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public int OrgID { get; set; }
    }
}
