using DataContextContract;
using DataEntity;
using DataRepositoryContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IBookDBContext _bookDBContext;

        public AuthorRepository(IBookDBContext bookDBContext)
        {
            _bookDBContext = bookDBContext;
        }

        /// <summary>
        /// Cette methode permet de créer un auteur.
        /// </summary>
        /// <param name="author">auteur ajouté.</param>
        /// <returns></returns>
        public async Task<Author> CreateAuthor(Author author)
        {
            var element = await _bookDBContext.Authors.AddAsync(author).ConfigureAwait(false);
            await _bookDBContext.SaveChangesAsync().ConfigureAwait(false);

            return element.Entity;
        }
    }
}
