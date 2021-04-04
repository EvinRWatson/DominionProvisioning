using System.ComponentModel.DataAnnotations.Schema;
namespace Dominion.Models
{
    public class StockList
    {
        public int StockID { get; set; }
        public string ItemName { get; set; }
        public string ImagePath { get; set; }
        public int OrgID { get; set; }
    }
}
