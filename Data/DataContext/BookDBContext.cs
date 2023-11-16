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
        public virtual DbSet<BookCategory> BookCategories { get; set; }


        /// <summary>
        /// Une donnée entrée pour un auteur et un livre, pour vérifier si la liaison à la Bdd fonctionne
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategory>().HasKey(bc => new { bc.BookId, bc.CategoryId });

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = 1,
                    Name = "Victor Hugo",
                    Nationality = "Français"
                }
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
