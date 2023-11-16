using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessModel.Books;
using BusinessModel.Categories;
using BusinessServiceContract;
using DataEntity;
using DataRepositoryContract;

namespace BusinessService
{
    public class CategoryService : ICategoryService
    {
        /// <summary>
        /// Le Book repository
        /// </summary>
        private readonly ICategoryRepository _categoryRepository;

        /// <summary>
        /// Le mapper
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Initialise une nouvelle instance <see cref="CategoryService"/>
        /// </summary>
        /// <param name="categoryRepository"></param>
        /// <param name="mapper"></param>
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Méthode qui récupère la liste des catégories
        /// </summary>
        /// <returns></returns>
        public async Task<List<CreateCategoryDto>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetAllAsync().ConfigureAwait(false);
            return _mapper.Map<List<CreateCategoryDto>>(categories);
        }

        public Task<CreateCategoryDto> CreateCategoriesAsync(CreateCategoryDto category)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode qui permet d'ajouter une catégorie
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public async Task<CreateCategoryDto> CreateCategoryAsync(CreateCategoryDto category)
        {
            var categoryEntity = _mapper.Map<Category>(category);
            var categoryCreated = await _categoryRepository.CreateElementAsync(categoryEntity).ConfigureAwait(false);
            return _mapper.Map<CreateCategoryDto>(categoryCreated);
        }
    }
}
