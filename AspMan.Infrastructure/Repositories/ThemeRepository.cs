using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AspMan.Core;
using AspMan.Core.Iterfaces;

namespace AspMan.Infrastructure.Repositories
{
    public class ThemeRepository : IThemeRepository
    {
        public void AddAsync(Theme dump)
        {
            throw new NotImplementedException();
        }

        public void Edit(Theme dump)
        {
            throw new NotImplementedException();
        }

        public Theme FindById(string dumpID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Theme> Get()
        {
            throw new NotImplementedException();
        }

        public void Remove(string dumpID)
        {
            throw new NotImplementedException();
        }

        Task<Theme> IRepository<Theme>.FindByIdAsync(string dumpID)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Theme>> IRepository<Theme>.GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
