using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FesbBoardBackend.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }
        public DateTime DueDate { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public int ColumnId { get; set; }

        [ForeignKey("ColumnId")]
        public Column Column { get; set; }
        
        public ICollection<Comment> Comments { get; set; }
    }
}
