using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;


namespace DataRepositoryContract
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// Cette methode permet de créer une catégorie.
        /// </summary>
        /// <param name="category">Catégorie ajoutée.</param>
        /// <returns></returns>
        Task<Category> CreateCategory(Category category);
    }
}
