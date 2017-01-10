using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FesbBoard.Data.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Users.db");
        }
    }

    public class User
    {
        public User()
        {
        }

        // To implement: Fluent API restrictions
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string Username { get; set; }
    }
}
