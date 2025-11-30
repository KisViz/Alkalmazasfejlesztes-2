using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace het12._2.Models
{
    public class Puppy
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0,1000)]
        public int Age { get; set; }
        [Required]
        [Range(0, 1000)]
        public Decimal Weigh { get; set; }
        [Required]
        [RegularExpression(@"^https?://.*\.(png|jpg)$")]
        public string photoLink { get; set; }
        [Required]
        [ForeignKey("ReferencedCategory")]
        [Display(Name = "ReferencedCategory.Name")]
        public int CategoryId { get; set; }
        public Category? ReferencedCategory { get; set; }
    }
}
