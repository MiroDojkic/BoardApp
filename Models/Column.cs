using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FesbBoardBackend.Models
{
    public class Column
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public int BoardId { get; set; }

        [ForeignKey("BoardId")]
        public Board Board { get; set; }
        public ICollection<Card> Cards { get; set; }
    }
}
