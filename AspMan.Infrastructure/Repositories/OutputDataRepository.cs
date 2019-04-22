using System.Collections.Generic;
using System.Threading.Tasks;
using AspMan.Core.Iterfaces;
using AspMan.Core.Models;

namespace AspMan.Infrastructure.Repositories
{
    public class OutputDataRepository : IOutputDataRepository
    {
        public void AddAsync(OutputData dump)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(OutputData dump)
        {
            throw new System.NotImplementedException();
        }

        public OutputData FindById(string dumpID)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<OutputData> Get()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string dumpID)
        {
            throw new System.NotImplementedException();
        }

        Task<OutputData> IRepository<OutputData>.FindByIdAsync(string dumpID)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<OutputData>> IRepository<OutputData>.GetAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}