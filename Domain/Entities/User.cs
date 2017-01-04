using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FesbBoard.Domain.Entities
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
        public User(string username)
        {
            this.Username = username;
        }
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string Username { get; set; }
    }
}
