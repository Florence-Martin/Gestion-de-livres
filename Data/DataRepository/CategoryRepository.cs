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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="CategoryRepository"/> 
        /// </summary>
        /// <param name="dBContext"></param>
        public CategoryRepository(IBookDBContext dBContext) : base(dBContext)
        {
        }
    }
}
