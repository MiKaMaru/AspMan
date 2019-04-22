using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AspMan.Core.Iterfaces;
using AspMan.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace AspMan.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private AppContext context;

        public TaskRepository(AppContext context)
        {
            this.context = context;
        }
        public async void AddAsync(Core.Models.Task dump)
        {
            await context.Tasks.AddAsync(dump);
            context.OnSaveAsync();
        }

        public void Edit(Core.Models.Task dump)
        {
            context.Update(dump);
            context.OnSaveAsync();
        }

        public  Core.Models.Task FindById(string dumpID)
        {
            int id;
            try
            {
                id = Convert.ToInt32(dumpID);

            }
            catch
            {
                id = -1;
            }
            var dump = (from r in context.Tasks where r.TaskId == id select r).FirstOrDefault();
            return dump;
        }

        public IEnumerable<Core.Models.Task> Get()
        {
            throw new NotImplementedException();
        }

        public async void Remove(string dumpID)
        {
            var task = await context.Tasks.FindAsync(CTreatProc.ToDigit(dumpID));
            context.Tasks.Remove(task);
            context.OnSaveAsync();
        }

        public async Task<Core.Models.Task> FindByIdAsync(string dumpID)
        {
            int id;
            try
            {
                id = Convert.ToInt32(dumpID);
            }
            catch
            {
                id = -1;
            }

            var dump = await context.Tasks.FirstOrDefaultAsync(m => m.TaskId == id);
            return dump;
        }

        Task<IEnumerable<Core.Models.Task>> IRepository<Core.Models.Task>.GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
