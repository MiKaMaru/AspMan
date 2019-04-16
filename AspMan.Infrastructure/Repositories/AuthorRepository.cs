using System.Collections.Generic;
using AspMan.Core;
using AspMan.Core.Iterfaces;

namespace AspMan.Infrastructure
{
    public class AuthorRepository : IAuthorRepository, IConcurrency
    {
        AppContext context = new AppContext();
        public void Add(Author author)
        {
            context.Authors.Add(author);

            throw new System.NotImplementedException();
        }

        public void Edit(Author author)
        {
            throw new System.NotImplementedException();
        }

        public Author FindById(string authorID)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Author> Get()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string authorID)
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
