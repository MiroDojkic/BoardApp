using System.ComponentModel.DataAnnotations;

namespace FesbBoard.Domain.Entities
{
    public class User
    {
        public User(int id, string username)
        {
            this.Id = id;
            this.Username = username;
        }
        
        [Key]
        public int Id { get; }
        [MaxLength(40)]
        public string Username { get; }
    }
}
