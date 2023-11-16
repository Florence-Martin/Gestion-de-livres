using BusinessModel.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract
{
    public interface IBookService
    {
        /// <summary>
        /// Méthode qui récupère la liste des livres
        /// </summary>
        /// <returns></returns>
        Task<List<ReadBookDto>> GetBooksAsync();

        /// <summary>
        /// Méthode qui permet d'ajouter un livre
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        Task<ReadBookDto> CreateBooksAsync(CreateBookDto book);

        /// <summary>
        /// Méthode permet de supprimer un livre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteBookAsync(int id, DeleteBookDto bookDto);


        /// <summary>
        /// Méthode permet de modifier un livre
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bookDto"></param>
        /// <returns></returns>
        Task<ReadBookDto> UpdateBookAsync(int id, UpdateBookDto bookDto);
    }
}
