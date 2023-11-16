using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel.Books
{
    public class CreateBookDto 
    {
        /// <summary>
        /// le titre du livre
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// la description du livre
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// l'auteur du livre
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// le prix du livre
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// la quantité en stock du livre
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// l'image du couverture du livre
        /// </summary>
        public byte BookCover { get; set; }

        /// <summary>
        /// le nom de l'auteur
        /// </summary>
        public string AuthorName { get; set; }
    }
}
