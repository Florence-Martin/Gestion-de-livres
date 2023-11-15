using DataContextContract;
using DataEntity;
using DataRepositoryContract;
using Microsoft.EntityFrameworkCore;

namespace DataRepository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="BookRepository"/> 
        /// </summary>
        /// <param name="dBContext"></param>
        public BookRepository(IBookDBContext dbContext) : base(dbContext)
        {

        }
    }
}
