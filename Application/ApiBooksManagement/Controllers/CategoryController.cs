using BusinessModel.Categories;
using BusinessServiceContract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiBooksManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        /// <summary>
        /// The book service
        /// </summary>
        private readonly ICategoryService _categoryService;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="CategoryController"/>
        /// </summary>
        /// <param name="categoryService"></param>
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Récupère la liste des catégories
        /// </summary>
        /// <returns></returns>
        //GET: api/<BookController>
        [HttpGet]
        public async Task<ActionResult<List<CreateCategoryDto>>> GetAsync()
        {
            var categories = await _categoryService.GetCategoriesAsync().ConfigureAwait(false);
            return Ok(categories);
        }

        /// <summary>
        /// Permet de créer une catégorie
        /// </summary>
        /// <param name="categoryDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<CreateCategoryDto>> PostAsync([FromBody] CreateCategoryDto categoryDto)
        {
            var createdCategory = await _categoryService.CreateCategoryAsync(categoryDto).ConfigureAwait(false);
            if (createdCategory == null)
            {
                return BadRequest();
            }
            return Ok(createdCategory);
        }
    }
}
