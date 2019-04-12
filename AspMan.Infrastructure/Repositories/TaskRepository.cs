using System;
using System.Collections.Generic;
using System.Text;
using AspMan.Core.Iterfaces;
using AspMan.Core.Models;

namespace AspMan.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public void Add(Task dump)
        {
            throw new NotImplementedException();
        }

        public void Edit(Task dump)
        {
            throw new NotImplementedException();
        }

        public Task FindById(string dumpID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> Get()
        {
            throw new NotImplementedException();
        }

        public void Remove(string dumpID)
        {
            throw new NotImplementedException();
        }
    }
}
