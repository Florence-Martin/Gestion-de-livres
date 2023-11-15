using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;


namespace DataRepositoryContract
{
    public interface IAuthorRepository
    {
        /// <summary>
        /// Cette methode permet de créer un auteur.
        /// </summary>
        /// <param name="author">Auteur ajouté.</param>
        /// <returns></returns>
        Task<Author> CreateAuthor(Author author);

    }
}
