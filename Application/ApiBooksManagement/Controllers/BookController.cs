using BusinessModel.Books;
using BusinessServiceContract;
using DataEntity;
using DataRepositoryContract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiBooksManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        /// <summary>
        /// The book service
        /// </summary>
        private readonly IBookService _bookService;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="BookController"/>
        /// </summary>
        /// <param name="bookService"></param>
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        /// <summary>
        /// Récupère la liste des livres
        /// </summary>
        /// <returns></returns>
        //GET: api/<BookController>
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var books = await _bookService.GetBooksAsync().ConfigureAwait(false);
            return Ok(books);
        }

        /// <summary>
        /// Permet de créer un livre
        /// </summary>
        /// <param name="bookDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ReadBookDto>> PostAsync([FromBody] CreateBookDto bookDto)
        {
            var createdBook = await _bookService.CreateBooksAsync(bookDto).ConfigureAwait(false);
            if (createdBook == null)
            {
                return BadRequest();
            }
            return Ok(createdBook);
        }

        /// <summary>
        /// Permet de supprimer un livre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id, [FromBody] DeleteBookDto deleteBookDto)
        {
            var deleted = await _bookService.DeleteBookAsync(id, deleteBookDto).ConfigureAwait(false);
            if (!deleted)
            {
                return NotFound();
            }
            return NoContent();
        }


        /// <summary>
        /// Permet de modifier un livre
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bookDto"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] UpdateBookDto bookDto)
        {
            var updatedBook = await _bookService.UpdateBookAsync(id, bookDto).ConfigureAwait(false);
            if (updatedBook == null)
            {
                return NotFound();
            }
            return Ok(updatedBook);
        }

    }
}
