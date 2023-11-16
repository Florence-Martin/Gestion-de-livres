using DataContextContract;
using DataEntity;
using DataRepositoryContract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="AuthorRepository"/> 
        /// </summary>
        /// <param name="dbContext"></param>
        public AuthorRepository(IBookDBContext dbContext) : base(dbContext)
        {

        }

        /// <summary>
        /// Méthode permet de récupérer le nom de l'auteur
        /// </summary>
        /// <param name="authorName"></param>
        /// <returns></returns>
        public async Task<Author> GetAuthorByNameAsync(string authorName)
        {
            return await _dBContext.Authors.FirstOrDefaultAsync(a => a.Name == authorName).ConfigureAwait(false);
        }
    }
}
