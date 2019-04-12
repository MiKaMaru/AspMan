using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspMan.Core.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }

        //Theme
        public int ThemeId { get; set; }
        public Theme Theme { get; set; }
        //Complexity
        public Complexity Complexity { get; set; }
        //Author
        public IList<TaskAuthor> TaskAuthor { get; set; }
        //Data
        public IList<TaskData> TaskDatas { get; set; }
    }
}
