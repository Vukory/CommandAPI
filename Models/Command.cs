using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings=false)]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required(AllowEmptyStrings=false)]
        public string Line { get; set; }

        [Required(AllowEmptyStrings=false)]
        public string Platform { get; set; }
    }
}