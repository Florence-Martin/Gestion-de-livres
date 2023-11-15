
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataRepositoryContract
{
    public interface IBookRepository
    {
        /// <summary>
        /// Cette methode permet de créer un livre.
        /// </summary>
        /// <param name="book">livre ajouté.</param>
        /// <returns></returns>
        Task<Book> CreateBook(Book book);


        /// <summary>
        /// Cette methode permet de supprimer un livre.
        /// </summary>
        /// <param name="book">Livre supprimer.</param>
        /// <returns></returns>
        Task<Book> DeleteBook(Book book);


        /// <summary>
        /// Cette methode permet de modifier un produit.
        /// </summary>
        /// <param name="book">Produit modifier.</param>
        /// <returns></returns>
        Task<Book> UpdateBook(Book book);


        /// <summary>
        /// Cette methode permet d'afficher tout les livre sous forme de liste.
        /// </summary>
        /// <param name="book">Liste de livres.</param>
        /// <returns></returns>
        Task<List<Book>> GetBook();


        /// <summary>
        /// Cette methode permet d'afficher un livre par son id.
        /// </summary>
        /// <param name="book">Livre.</param>
        /// <returns></returns>
        Task<Book> GetBookById(int bookId);
    }
}
