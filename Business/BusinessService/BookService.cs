using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessModel.Books;
using BusinessServiceContract;
using DataEntity;
using DataRepositoryContract;

namespace BusinessService
{
    public class BookService : IBookService
    {
        /// <summary>
        /// Le Book repository
        /// </summary>
        private readonly IBookRepository _bookRepository;

        /// <summary>
        /// Le Author repository
        /// </summary>
        private readonly IAuthorRepository _authorRepository;

        /// <summary>
        /// Le mapper
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Initialise une nouvelle instance <see cref="BookService"/>
        /// </summary>
        /// <param name="bookRepository"></param>
        /// <param name="authorRepository"></param>
        /// <param name="mapper"></param>
        public BookService(IBookRepository bookRepository, IAuthorRepository authorRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Méthode qui récupère la liste des livres
        /// </summary>
        /// <returns></returns>
        public async Task<List<ReadBookDto>> GetBooksAsync()
        {
            var books = await _bookRepository.GetAllAsync().ConfigureAwait(false);
            return _mapper.Map<List<ReadBookDto>>(books);
        }

        /// <summary>
        /// Méthode qui permet d'ajouter un livre
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public async Task<ReadBookDto> CreateBooksAsync(CreateBookDto book)
        {
            var bookEntity = _mapper.Map<Book>(book);
            var bookCreated = await _bookRepository.CreateElementAsync(bookEntity).ConfigureAwait(false);
            return _mapper.Map<ReadBookDto>(bookCreated);
        }

        /// <summary>
        /// Méthode permet de modifier un livre
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bookDto"></param>
        /// <returns></returns>
        public async Task<ReadBookDto> UpdateBookAsync(int id, UpdateBookDto bookDto)
        {
            var existingBook = await _bookRepository.GetByKeyAsync(id).ConfigureAwait(false);

            if (existingBook == null)
            {
                return null;
            }

            existingBook.Title = bookDto.Title;

            await _bookRepository.UpdateElementAsync(existingBook).ConfigureAwait(false);
            return _mapper.Map<ReadBookDto>(existingBook);
        }


        /// <summary>
        /// Méthode permet de supprimer un livre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteBookAsync(int id, DeleteBookDto deleteBookDto)
        {
            var bookToDelete = await _bookRepository.GetByKeyAsync(id).ConfigureAwait(false);

            if (bookToDelete == null)
            {
                return false;
            }

            await _bookRepository.DeleteElementAsync(bookToDelete).ConfigureAwait(false);
            return true;
        }
    }
}
