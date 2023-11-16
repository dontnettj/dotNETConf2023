using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore8.ValueObjectsComplexTypes
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required Contact Contact { get; set; }
    }

    [ComplexType]
    public record Contact
    {
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
    }

    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost;Initial Catalog=ValueObjectsComplexTypes;integrated security=True;TrustServerCertificate=True;");
        }
        public DbSet<User> Users { get; set; }
    }
}
