using System;
using AspMan.Core;
using AspMan.Core.Iterfaces;
using AspMan.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AspMan.Infrastructure
{
    public class AuthorRepository : IAuthorRepository, IConcurrency, IContextMaker
    {
        AppContext context = new AppContext();
        public void Add(Author dump)
        {
            context.Authors.Add(dump);
            context.OnSave();
        }


        public void Edit(Author dump)
        {
            //context.Entry(dump).State;
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

        public IEnumerable<Author> Get()
        {
            return context.Authors;
        }

        public void Remove(string dumpID)
        {
            Author author = FindById(dumpID);
            context.Authors.Remove(author);
            context.OnSave();
            throw new System.NotImplementedException();
        }

        void IContextMaker.ContextApply(AppContext dump)
        {

            throw new System.NotImplementedException();
        }

        bool IConcurrency.IsUpdate()
        {
            throw new System.NotImplementedException();
        }

        void IConcurrency.TryUpdate()
        {
            throw new System.NotImplementedException();
        }
    }
}
