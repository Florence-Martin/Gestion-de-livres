using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContextContract;
using DataEntity;
using DataRepositoryContract;

namespace DataRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IBookDBContext _bookDBContext;

        public CategoryRepository(IBookDBContext bookDBContext)
        {
            _bookDBContext = bookDBContext;
        }

        /// <summary>
        /// Cette methode permet de créer une catégorie.
        /// </summary>
        /// <param name="category">catégorie ajoutée.</param>
        /// <returns></returns>
        public async Task<Category> CreateCategory(Category category) 
        {
            var element = await _bookDBContext.Categories.AddAsync(category).ConfigureAwait(false);
            await _bookDBContext.SaveChangesAsync().ConfigureAwait(false);

            return element.Entity;
        }
    }
}
