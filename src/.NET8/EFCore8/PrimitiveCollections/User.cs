using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore8.PrimitiveCollections
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required ICollection<string> PhoneNumbers { get; set; }
    }

    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost;Initial Catalog=PrimitiveCollections;integrated security=True;TrustServerCertificate=True;");
        }
        public DbSet<User> Users { get; set; }
    }
}
