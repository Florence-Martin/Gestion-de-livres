using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;


namespace DataRepositoryContract
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        /// <summary>
        /// Méthode permet de récupérer le nom de l'auteur
        /// </summary>
        /// <param name="authorName"></param>
        /// <returns></returns>
        Task<Author> GetAuthorByNameAsync(string authorName);
    }
}
