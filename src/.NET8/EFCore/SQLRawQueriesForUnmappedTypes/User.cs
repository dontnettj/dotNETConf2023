using Microsoft.EntityFrameworkCore;

namespace EFCore8.SQLRawQueriesForUnmappedTypes
{
    public class Order
    {
        public int Id { get; set; }
        public required string Contents { get; set; }
        public required int Quantity { get; set; }
        public required decimal Price { get; set; }
    }

    public record MyOrderReport
    {
        public decimal TotalPrice { get; set; }

        public required string Title { get; set; }
    }

    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SQLRawQueriesForUnmappedTypes.db;");
        }
        public DbSet<Order> Orders { get; set; }
    }
}
