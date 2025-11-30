using System.ComponentModel.DataAnnotations;

namespace het12._3.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string TeamName { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
