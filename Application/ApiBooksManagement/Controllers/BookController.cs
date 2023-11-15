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
        /// The book repository
        /// </summary>
        private readonly IBookRepository _bookRepository;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="BookController"/>
        /// </summary>
        /// <param name="bookRepository"></param>
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        //GET: api/<BookController>
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
           var books = await _bookRepository.GetAllAsync().ConfigureAwait(false);
           return Ok(books);
        }

    }
}
