using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AspMan.Core;
using AspMan.Core.Iterfaces;

namespace AspMan.Infrastructure.Repositories
{
    public class ComplexityRepository : IComplexityRepository
    {
        public void AddAsync(Complexity dump)
        {
            throw new NotImplementedException();
        }

        public void Edit(Complexity dump)
        {
            throw new NotImplementedException();
        }

        public Complexity FindById(string dumpID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Complexity> Get()
        {
            throw new NotImplementedException();
        }

        public void Remove(string dumpID)
        {
            throw new NotImplementedException();
        }

        Task<Complexity> IRepository<Complexity>.FindByIdAsync(string dumpID)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Complexity>> IRepository<Complexity>.GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
