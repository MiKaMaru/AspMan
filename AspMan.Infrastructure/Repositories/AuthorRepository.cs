using AspMan.Core;
using AspMan.Core.Iterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMan.Infrastructure
{
    public class AuthorRepository : IAuthorRepository
    {
        private AppContext context;
        public AuthorRepository(AppContext context)
        {
            this.context = context;
        }
        public async void AddAsync(Author dump)
        {
            await context.Authors.AddAsync(dump);
            context.OnSaveAsync();
        }
        public async void Edit(Author dump)
        {

            context.Update(dump);
            context.OnSaveAsync();
            //context.Entry(dump).State;
        }
        public async Task<Author> FindByIdAsync(string dumpID)
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
            //var dump = (from r in context.Authors where r.AuthorId == id select r).FirstOrDefaultAsync();
            var dump = await context.Authors.FirstOrDefaultAsync(m => m.AuthorId == id);
            return dump;
        }
        public Author FindById(string dumpID)
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
            var dump = (from r in context.Authors where r.AuthorId == id select r).FirstOrDefault();
            return dump;
        }
        public async Task<IEnumerable<Author>> GetAsync()
        {
            return await context.Authors.ToListAsync();
        }

        public IEnumerable<Author> Get()
        {
            throw new NotImplementedException();
        }

        public async void Remove(string dumpID)
        {
            var author = await context.Authors.FindAsync(CTreatProc.ToDigit(dumpID));
            context.Authors.Remove(author);
            context.OnSaveAsync();

        }

        IEnumerable<Author> IRepository<Author>.Get()
        {
            throw new NotImplementedException();
        }
    }
}
