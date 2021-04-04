using Microsoft.EntityFrameworkCore;
using Dominion.Models;

namespace Dominion.Data
{
    public class DominionContext : DbContext
    {
        public DominionContext(DbContextOptions<DominionContext> options) : base(options) { }

        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<StockList> StockList { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
