using System.Collections.Generic;
using AspMan.Core;
using AspMan.Core.Iterfaces;

namespace AspMan.Infrastructure
{
    public class AuthorRepository : IAuthorRepository
    {
        public void Add(Author author)
        {
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

        public IEnumerable<Author> GetAuthor()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string authorID)
        {
            throw new System.NotImplementedException();
        }
    }
}
