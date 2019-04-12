using System;
using System.Collections.Generic;
using System.Text;

namespace AspMan.Core.Iterfaces
{
    public interface IRepository<T>
    {
        void Add(T dump);
        void Edit(T dump);
        void Remove(string dumpID);
        IEnumerable<T> Get();
        T FindById(string dumpID);
    }
}
