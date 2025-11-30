using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace het12._3.Models
{
    public enum Position
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Forward
    }

    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(16,50)]
        public int Age { get; set; }
        public Position Position { get; set; }
        [Required]
        public bool Retired { get; set; }
        [Required]
        [ForeignKey("ReferencedTeam")]
        [Display(Name = "Team")]
        public int TeamId { get; set; }
        [Display(Name = "Team")]
        public virtual Team? ReferencedTeam { get; set; }

    }
}
