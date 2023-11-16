using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;
using Microsoft.EntityFrameworkCore;

namespace DataContextContract
{
    public interface IBookDBContext : IDBContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Author> Authors { get; set; }
        DbSet<BookCategory> BookCategories { get; set; }

    }
}
