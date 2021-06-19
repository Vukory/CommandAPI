using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        [Required(AllowEmptyStrings=false)]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required(AllowEmptyStrings=false)]
        public string Line { get; set; }

        [Required(AllowEmptyStrings=false)]
        public string Platform { get; set; }
    }
}