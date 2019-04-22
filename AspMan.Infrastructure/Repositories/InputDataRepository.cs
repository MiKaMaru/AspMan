using System.Collections.Generic;
using System.Threading.Tasks;
using AspMan.Core.Iterfaces;
using AspMan.Core.Models;

namespace AspMan.Infrastructure.Repositories
{
    public class InputDataRepository : IInputDataRepository
    {
        public void AddAsync(InputData dump)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(InputData dump)
        {
            throw new System.NotImplementedException();
        }

        public InputData FindById(string dumpID)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<InputData> Get()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string dumpID)
        {
            throw new System.NotImplementedException();
        }

        Task<InputData> IRepository<InputData>.FindByIdAsync(string dumpID)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<InputData>> IRepository<InputData>.GetAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}