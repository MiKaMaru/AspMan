using AspMan.Core.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspMan.Core
{
    public class Author
    {
        public int AuthorId { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 1, ErrorMessage = "Недопустимая длина имени")]
        public string Name { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Undef rating")]
        public int Rating { get; set; }

        public IList<TaskAuthor> TaskAuthors { get; set; }
    }
}
