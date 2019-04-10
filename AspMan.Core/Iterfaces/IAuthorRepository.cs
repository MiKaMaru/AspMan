using System;
using System.Collections.Generic;
using System.Text;

namespace AspMan.Core.Iterfaces
{
    interface IAuthorRepository
    {
        void Add(Author author);
        void Edit(Author author);
        void Remove(string authorID);
        IEnumerable<Author> GetAuthor();
        Author FindById(string authorID);
    }
}
