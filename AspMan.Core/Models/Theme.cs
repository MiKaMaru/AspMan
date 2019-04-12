using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AspMan.Core.Models;

namespace AspMan.Core
{
    public class Theme
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 1, ErrorMessage = "Недопустимая длина имени")]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
