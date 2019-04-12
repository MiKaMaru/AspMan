using System.ComponentModel.DataAnnotations;

namespace AspMan.Core
{
    public class Complexity
    {
        public int ComplexityId { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Недопустимая длина имени")]
        public string Name { get; set; }
        
    }
}
