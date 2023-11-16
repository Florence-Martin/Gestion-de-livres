using BusinessModel.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel.Categories;

namespace BusinessServiceContract
{
    public interface ICategoryService
    {
        /// <summary>
        /// Méthode qui récupère la liste des catégories
        /// </summary>
        /// <returns></returns>
        Task<List<CreateCategoryDto>> GetCategoriesAsync();

        /// <summary>
        /// Méthode qui permet d'ajouter une catégorie
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Task<CreateCategoryDto> CreateCategoryAsync(CreateCategoryDto category);

    }
}
