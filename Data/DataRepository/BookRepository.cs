using DataContextContract;
using DataEntity;
using DataRepositoryContract;
using Microsoft.EntityFrameworkCore;

namespace DataRepository
{
    public class BookRepository : IBookRepository
    {
        private readonly IBookDBContext _bookDBContext;

        public BookRepository(IBookDBContext bookDBContext)
        {
            _bookDBContext = bookDBContext;
        }

        /// <summary>
        /// Cette methode permet de créer un livre.
        /// </summary>
        /// <param name="book">Livre ajouté.</param>
        /// <returns></returns>
        public async Task<Book> CreateBook(Book book)
        {
            var element = await _bookDBContext.Books.AddAsync(book).ConfigureAwait(false);
            await _bookDBContext.SaveChangesAsync().ConfigureAwait(false);

            return element.Entity;
        }

        /// <summary>
        /// Cette methode permet de supprimer un livre.
        /// </summary>
        /// <param name="book">Livre supprimé</param>
        /// <returns></returns>
        public async Task<Book> DeleteBook(Book book)
        {
            var element = _bookDBContext.Books.Remove(book);
            await _bookDBContext.SaveChangesAsync().ConfigureAwait(false);

            return element.Entity;
        }

        /// <summary>
        /// Cette methode permet de modifier un livre.
        /// </summary>
        /// <param name="book">Livre modifié</param>
        /// <returns></returns>
        public async Task<Book> UpdateBook(Book book)
        {
            var element = _bookDBContext.Books.Update(book);
            await _bookDBContext.SaveChangesAsync().ConfigureAwait(false);

            return element.Entity;
        }

        public Task<List<Book>> GetBook()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cette methode permet d'afficher tout les livres.
        /// </summary>
        /// <param name="livre">Liste des livres.</param>
        /// <returns></returns>
        //public async Task<List<Book>> GetBook()
        //{
        //    //TODO
        //}

        /// <summary>
        /// Cette methode permet d'afficher un livre par son id.
        /// </summary>
        /// <param name="livre">Livre.</param>
        /// <returns></returns>
        public async Task<Book> GetBookById(int bookId)
        {
            return await _bookDBContext.Books
                .FirstOrDefaultAsync(x => x.BookId == bookId)
                .ConfigureAwait(false);

        }
    }
}
