using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace het_12._2.Models
{
    public class Kisallat
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public Decimal Weigh { get; set; }
        [Required]
        public string PhotoUrl{ get; set; }
        [Required]
        [ForeignKey("Kategoria")]
        public int CategoryID { get; set; }
        [Required]
        public Kategoria Kategoria { get; set; }
    }
}
