using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspMan.Core.Iterfaces
{
    public interface IRepository<T>
    {
        void AddAsync(T dump);
        void Edit(T dump);
        void Remove(string dumpID);
        IEnumerable<T> Get();
        T FindById(string dumpID);
        Task<IEnumerable<T>> GetAsync();
        Task<T> FindByIdAsync(string dumpID);
    }
}
