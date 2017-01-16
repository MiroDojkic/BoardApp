using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FesbBoardBackend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Username { get; set; }
        public ICollection<UserBoard> UserBoards { get; set; }
        public ICollection<Card> Cards { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
