using System.ComponentModel.DataAnnotations.Schema;
namespace Dominion.Models
{
    public class Inventory
    {
        public int StockID { get; set; }
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public int OrgID { get; set; }
    }
}
