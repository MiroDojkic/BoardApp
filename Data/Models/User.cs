using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FesbBoard.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Username { get; set; }
        public ICollection<UserBoard> UserBoards { get; set; }
    }
}
