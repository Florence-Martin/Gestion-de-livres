using DataContextContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;
using DataRepositoryContract;

namespace DataRepository
{
    public class BookCategoryRepository : GenericRepository<BookCategory>, IBookCategoryRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="BookCategoryRepository"/> 
        /// </summary>
        /// <param name="dBContext"></param>
        public BookCategoryRepository(IBookDBContext dbContext) : base(dbContext)
        {

        }
    }
}
