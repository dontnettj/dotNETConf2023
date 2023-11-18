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

    public class Contact()
    {
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
    }

    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dbValueObjectsComplexTypes.db;");
        }
        public DbSet<User> Users { get; set; }
    }
}
