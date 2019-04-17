using System;
using System.Collections.Generic;
using System.Text;

namespace AspMan.Core.Models
{
    public class InputData
    {
        public int InputDataId { get; set; }
        public string Content { get; set; }

        public OutputData Output { get; set; }

        public IList<TaskData> TaskDatas { get; set; }
    }
    public class OutputData
    {
        public int OutputDataId { get; set; }
        public string Content { get; set; }

        //а на сколько это OneToOne?
        public int InputDataId { get; set; }
        public InputData Input { get; set; }
    }

    public class TaskData
    {
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int InputDataId { get; set; }
        public InputData InputData { get; set; }
    }
    public class TaskAuthor
    {
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
    
}
