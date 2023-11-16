using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel.Books
{
    public class DeleteBookDto : CreateBookDto
    {
        /// <summary>
        /// Identifiant du livre
        /// </summary>
        public int BookId { get; set; }
    }
}
