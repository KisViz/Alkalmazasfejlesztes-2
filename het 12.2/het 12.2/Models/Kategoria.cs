using System.ComponentModel.DataAnnotations;

namespace het_12._2.Models
{
    public class Kategoria
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}
