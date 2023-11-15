using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContextContract;
using DataEntity;
using Microsoft.EntityFrameworkCore;

namespace DataContext
{
    public partial class BookDBContext : DbContext, IBookDBContext

    {
        public BookDBContext()
        {

        }

        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }


        /// <summary>
        /// Une donnée entrée d'auteur pour vérifier si la liaison à la Bdd fonctionne
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var author = new Author()
            {
                AuthorId = 1,
                Name = "Victor Hugo",
                Nationality = "Français"
            };
            modelBuilder.Entity<Author>().HasData(author);
        }
    }
}
