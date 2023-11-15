using DataContextContract;
using DataEntity;
using DataRepositoryContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="AuthorRepository"/> 
        /// </summary>
        /// <param name="dBContext"></param>
        public AuthorRepository(IBookDBContext dbContext) : base(dbContext)
        {

        }
    }
}
